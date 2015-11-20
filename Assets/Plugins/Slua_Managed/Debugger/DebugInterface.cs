// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

// Comment out this line to switch off remote debugger for slua
#define LuaDebugger

namespace SLua
{
	using UnityEngine;
	using System.Collections;
	using System.Collections.Generic;
	using SLua;
	using System;
	using System.Net;
	using System.Net.Sockets;
	using LuaInterface;
	using System.IO;
	using System.Text.RegularExpressions;
	using System.Reflection;

	class DebugInterface : LuaObject
	{
		LuaState state;
		Socket server;
		Socket client;
		bool start = false;

		const int RecvMax = 1024;
		byte[] recvBuffer = new byte[RecvMax];
		bool debugMode = false;
		int packageLen = 0;
		Dictionary<string, string[]> luaSource = new Dictionary<string, string[]>();
		static Dictionary<string, string> sourceMd5 = new Dictionary<string, string>();
		static Dictionary<string, string> md5Source = new Dictionary<string, string>();

		const int DebugPort = 10240;


		static DebugInterface instance;

		const string usageTips =@"
add break point					b <filename>:<lineno>
remove break point              delete <break point index>
list exists break points		list
clear all break points          clear
-------------Debug Command-------------
continue                  		c
next                			n
step              				s
print traceback              	bt
watch local/up value  			watch
";

		public DebugInterface(LuaState L)
		{
			state=L;
			instance=this;

			IntPtr l = L.L;
			getTypeTable(l, "LuaDebugger");
			addMember(l, output, false);
			addMember(l, onBreak, false);
			addMember(l, md5, false);
			createTypeMetatable(l, typeof(DebugInterface));
		}

		public static void require(string f,byte[] bytes)
		{
#if LuaDebugger
			System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
			byte[] hashBytes = md5.ComputeHash(bytes);

			// Convert the encrypted bytes back to a string (base 16)
			string hashString = "";

			for (int i = 0; i < hashBytes.Length; i++)
			{
				hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
			}

			string m = hashString.PadLeft(32, '0');
			sourceMd5[m] = f.ToLower();
			md5Source[f.ToLower()] = m;
#endif
		}


		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int output(IntPtr l)
		{
			try
			{
				string str;
				LuaObject.checkType(l, 1, out str);
				instance.echo(str);
				pushValue(l, true);
				return 1;
			}
			catch (Exception e)
			{
				return error(l,e);
			}
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int onBreak(IntPtr l)
		{
			try
			{
				string f;
				checkType(l, 1, out f);
				int line;
				checkType(l, 2, out line);
				string md5;
				checkType(l, 3, out md5);
				instance.onBreak(f,line,md5);
				pushValue(l, true);
				return 1;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int md5(IntPtr l)
		{
			try
			{
				string f;
				checkType(l, 1, out f);
				string md5=instance.md5(f);
				pushValue(l, true);
				pushValue(l, md5);
				return 2;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}


		string fetchLuaSource(string fileName, int line=-1, int range=3)
		{
			if (!luaSource.ContainsKey(fileName))
			{
				byte[] bytes = LuaState.loadFile(fileName);
				if (bytes == null)
				{
					return null;
				}

				string text = System.Text.Encoding.UTF8.GetString(bytes, 0, bytes.Length);
				text = text.Replace("\r\n", "\n");
				string[] splitLines = text.Split(new char[] { '\n' });
				luaSource.Add(fileName, splitLines);
			}

			
			var lines = luaSource[fileName];


			int start,end;
			if (line >= 0)
			{
				start = line - range;
				end = line + range;
				if (start < 0) start = 0;
				if (end >= lines.Length) end = lines.Length;
			}
			else
			{
				start = 0;
				end = lines.Length;
			}

			string ret = "";
			for (int n = start; n < end; n++)
			{
				ret += lines[n];
				ret += "\n";
			}
			return ret;

		}

		public void init()
		{
#if LuaDebugger
			try
			{
				IPEndPoint localEP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), DebugPort);
				server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
				server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
				server.Bind(localEP);
				server.Listen(10);
				server.BeginAccept(new AsyncCallback(onClientConnect), server);
				Debug.Log("Opened lua debugger interface at " + localEP.ToString());

				// redirect output to client socket
				var luaFunc = state.getFunction("Slua.ldb.setOutput");
				luaFunc.call((LuaCSFunction)output);
			}
			catch (Exception e)
			{
				Debug.LogError(string.Format("LuaDebugger listened failed for reason:：{0}", e.Message));
			}
#endif
		}

		public void update()
		{
#if LuaDebugger
			if (client == null || !client.Connected)
				return;

			process();
#endif
		}

		void error(string err)
		{
			send("ret bad {0}", err);
		}

		void ok(string str)
		{
			send("ret ok {0}", str);
		}

		void process()
		{
			while (true)
			{
				if (client == null || !client.Connected)
					break;

				int len;
				if (recvCmd(recvBuffer, out len))
				{
					string str = System.Text.Encoding.UTF8.GetString(recvBuffer, 0, len);
					str=str.Trim();

					try
					{
						if(doCommand(str))
							send("ret ok");
						else
							send("ret bad");
					}
					catch (Exception e)
					{
						error(e.Message);
						Debug.LogError(e.Message);
					}
				}
				else
					break;
			}
		}

		bool recvCmd(byte[] bytes, out int len)
		{
			len = 0;
			try
			{
				if (packageLen == 0 && client.Available >= sizeof(int))
				{
					client.Receive(bytes, sizeof(int), SocketFlags.None);
					packageLen = BitConverter.ToInt32(recvBuffer, 0);
				}

				if (packageLen < 0)
				{
					Debug.LogError("Invalid packaged received.");
					return false;
				}

				if (packageLen > 0 && client.Available >= packageLen)
				{

					if (packageLen > RecvMax)
					{
						Debug.LogError("Invalid debug command received.");
						return false;
					}

					client.Receive(recvBuffer, packageLen, SocketFlags.None);
					len = packageLen;
					packageLen = 0;

					return true;
				}
			}
			catch (SocketException)
			{
				onClientDisconnect();
			}
			return false;
		}


		public void send(string str)
		{
			if (client != null && client.Connected)
			{
				client.Blocking = true;
				byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
				int bytelen = bytes.Length;
				byte[] len = BitConverter.GetBytes(bytelen);
				client.Send(len);
				client.Send(bytes);
				client.Blocking = false;
			}
		}

		public void send(string fmt, params object[] args)
		{
			string str = string.Format(fmt, args);
			send(str);
		}

		public void echo(string str)
		{
			send("print " + str);
		}

		public bool isStarted
		{
			get
			{
				return client != null && client.Connected && start;
			}
		}

		void onClientConnect(IAsyncResult target)
		{
			if (server == null)
				return;

			client = server.EndAccept(target);
			client.Blocking = false;

			server.BeginAccept(new AsyncCallback(onClientConnect), server);

			debugMode = false;

			Debug.Log("New debug session connected");
		}

		public void close()
		{
			if (client != null && client.Connected)
			{
				client.Close();
				client = null;
			}

			if (server != null)
			{
				try
				{
					server.Shutdown(SocketShutdown.Both);
				}
				catch (Exception)
				{ }
				server.Close();
				server = null;
			}

			Debug.Log("Closed lua debugger interface.");

		}

		void onClientDisconnect()
		{
			state.doString("Slua.ldb.clearBreakPoint()");

			client.Close();
			client = null;

			Debug.Log("Debug session disconnected");
		}

		public string md5(string f)
		{
			string md5;
			if (md5Source.TryGetValue(f, out md5))
				return md5;
			return null;
		}

		public void onBreak(string f,int line,string md5)
		{
			send("break {0},{1},{2}", f, line, md5);
			debugMode = true;
			while (debugMode && (client!=null))
			{
				process();
			}
			send("resume");
		}

		bool cmdquit(string tail)
		{
			onClientDisconnect();
			return true;
		}

		bool cmdstart(string tail) {
			start = true;
			return true;
		}

		bool cmdfs(string tail)
		{
			if (tail == "")
			{
				error("arg");
				return false;
			}

			string[] fileNameAndLine = tail.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
			string fileName = fileNameAndLine[0];
			int line = -1, range = 3;
			if(fileNameAndLine.Length>1)
				line = int.Parse(fileNameAndLine[1]);
			if(fileNameAndLine.Length>2)
				range = int.Parse(fileNameAndLine[2]);


			ok(fetchLuaSource(fileName, line, range));
			return false;
		}


		bool cmdb(string tail) {
			if (tail == "")
			{
				error("arg");
				return false;
			}

			string[] fileNameAndLine = tail.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
			string fileName = fileNameAndLine[0];
			int line = int.Parse(fileNameAndLine[1]);
			var luaFunc = state.getFunction("Slua.ldb.addBreakPoint");
			luaFunc.call(fileName, line);
			return true;
		}


		bool cmdb5(string tail)
		{
			if (tail == "")
			{
				error("arg");
				return false;
			}

			string[] fileNameAndLine = tail.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
			string md5 = fileNameAndLine[0];
			int line = int.Parse(fileNameAndLine[1]);
			var luaFunc = state.getFunction("Slua.ldb.addBreakPointMD5");
			luaFunc.call(md5, line);
			return true;
		}

		bool deletebp(string tail)
		{
			if (tail == "")
			{
				error("arg");
				return false;
			}

			int breakPointIndex = int.Parse(tail);
			var luaFunc = state.getFunction("Slua.ldb.delBreakPoint");
			luaFunc.call(breakPointIndex);
			return true;
		}

		bool cmddelete(string tail)
		{
			return deletebp(tail);
		}

		bool cmddel(string tail){
			deletebp(tail);
			return true;
		}

		bool cmdlist(string tail)
		{
			state.doString("Slua.ldb.showBreakPointList()");
			return true;
		}

		bool cmdhelp(string tail)
		{
			echo(usageTips);
			return true;
		}

		bool cmdclear(string tail)
		{
			state.doString("Slua.ldb.clearBreakPoint()");
			return true;
		}

		bool cmdc(string tail)
		{
			if (!debugMode)
				return false;
			debugMode = false;
			state.doString("Slua.ldb.continue()");
			return true;
		}

		bool cmds(string tail)
		{
			if (!debugMode)
				return false;
			debugMode = false;
			state.doString("Slua.ldb.stepIn()");
			return true;
		}

		bool cmdn(string tail)
		{
			if (!debugMode)
				return false;
			debugMode = false;
			state.doString("Slua.ldb.stepOver()");
			return true;
		}

		bool cmdbt(string bt)
		{
			if (!debugMode)
				return false;

			state.doString("Slua.ldb.bt()");
			return true;
		}


		bool cmdwatch(string bt)
		{
			if (!debugMode)
				return false;

			state.doString("Slua.ldb.watch()");
			return true;
		}

		bool cmdp(string r)
		{
			var luaFunc = state.getFunction("Slua.ldb.printExpr");
			luaFunc.call(r);
			return true;
		}


		bool doCommand(string str)
		{
			int index = str.IndexOf(" ");
			string cmd = str;
			string tail = "";
			if (index > 0)
			{
				cmd = str.Substring(0, index).Trim().ToLower();
				tail = str.Substring(index + 1);
			}


			cmd="cmd"+cmd;
			MethodInfo mi = this.GetType().GetMethod(cmd,BindingFlags.Instance|BindingFlags.NonPublic);
			if(mi!=null) {
				return (bool)mi.Invoke(this,new object[]{tail});
			}
			else {
				if (!string.IsNullOrEmpty(str))
				{
					var luaFunc = state.getFunction("Slua.ldb.printExpr");
					object[] rets=(object[])luaFunc.call(str);
					if (((bool)rets[0]) == false)
					{
						error(rets[1] as string);
						return false;
					}
					return true;
				}
			}

			return true;
		}
	}
}
