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

		const int DebugPort = 10240;
		static Regex re = new Regex(@"\$\((\w+)\)");


		static DebugInterface instance;

		const string usageTips =@"
    add break point					b <filename>:<lineno>
    remove break point              delete <break point index>
    list exists break points		list
    clear all break points          clear
    -------------Commands-------------
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
			addMember(l, fetchLuaSource, false);
			addMember(l, onBreak, false);
			createTypeMetatable(l, typeof(DebugInterface));
		}


		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int output(IntPtr l)
		{
			try
			{
				string str;
				LuaObject.checkType(l, 1, out str);
				instance.debugPrint(str);
				pushValue(l, true);
				return 1;
			}
			catch (Exception e)
			{
				return error(l,e);
			}
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int fetchLuaSource(IntPtr l)
		{
			try
			{
				string fn;
				checkType(l, 1, out fn);
				int line;
				checkType(l, 2, out line);
				pushValue(l, true);
				pushValue(l, instance.fetchLuaSource(fn, line));
				return 2;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		static int onBreak(IntPtr l)
		{
			try
			{
				instance.onBreak();
				pushValue(l, true);
				return 1;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}


		string fetchLuaSource(string fileName, int line)
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
			if (line <= 0 || line > lines.Length)
			{
				return null;
			}
			return lines[line - 1];
		}

		public void init()
		{
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
		}

		public void update()
		{
			if (client == null || !client.Connected)
				return;

			process();
		}

		bool process()
		{
			while (true)
			{
				int len;
				if (recvCmd(recvBuffer, out len))
				{
					string str = System.Text.Encoding.UTF8.GetString(recvBuffer, 0, len);
					str = str.Replace("\n", "");

					try
					{
						if(doCommand(str))
							return true;
					}
					catch (Exception e)
					{
						debugPrint(e.Message + "\n");
						Debug.LogError(e.Message);
					}
					prompt();
				}
				else
					break;
			}
			return false;
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
					len = packageLen;
					packageLen = 0;
					return true;
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


		public void debugPrint(string str)
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
			debugPrint("$(Connected)");
			prompt();
		}

		void prompt()
		{
			if (debugMode)
			{
				debugPrint("$(PromptDebug)");
			}
			else
			{
				debugPrint("$(Prompt)");
			}
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
			state.doString("ldb.clearBreakPoint()");
			client.Close();
		}

		public void onBreak()
		{
			debugMode = true;
			while (true)
			{
				if (!client.Connected)
					break;

				prompt();

				while (client.Connected)
				{
					if (process())
					{
						debugMode = false;
						prompt();
						return;
					}
				}
			}
		}

		void cmdStart() {
			start = true;
		}

		bool doControlCode(string code)
		{
			code="cmd"+code;

			MethodInfo mi = this.GetType().GetMethod(code, BindingFlags.Instance | BindingFlags.NonPublic);
			if (mi != null) mi.Invoke(this, null);
			else Debug.LogError(string.Format("Can't find control handler {0}",code));
			return false;
		}


		bool isControlCode(string cmd,out string code)
		{
			Match m = re.Match(cmd);
			if(m.Success) {
				code = m.Groups[1].Value;
				return true;
			}
			code=null;
			return false;
		}

		bool cmdb(string tail) {
			if (tail == "")
			{
				debugPrint("usage:b main:123\n");
				return false;
			}

			string[] fileNameAndLine = tail.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
			string fileName = fileNameAndLine[0];
			int line = int.Parse(fileNameAndLine[1]);
			var luaFunc = state.getFunction("Slua.ldb.addBreakPoint");
			luaFunc.call(fileName, line);
			return false;
		}

		bool deletebp(string tail)
		{
			if (tail == "")
			{
				debugPrint("usage:del #123\n");
				return false;
			}

			int breakPointIndex = int.Parse(tail);
			var luaFunc = state.getFunction("Slua.ldb.delBreakPoint");
			luaFunc.call(breakPointIndex);
			return false;
		}

		bool cmddelete(string tail)
		{
			return deletebp(tail);
		}

		bool cmddel(string tail)
		{
			return deletebp(tail);
		}

		bool cmdlist(string tail)
		{
			state.doString("Slua.ldb.showBreakPointList()");
			return false;
		}

		bool cmdhelp(string tail)
		{
			debugPrint(usageTips);
			return false;
		}

		bool cmdclear(string tail)
		{
			state.doString("Slua.ldb.clearBreakPoint()");
			return false;
		}

		bool cmdc(string tail)
		{
			if (!debugMode)
				return true;

			state.doString("Slua.ldb.continue()");
			return true;
		}

		bool cmds(string tail)
		{
			if (!debugMode)
				return true;

			state.doString("Slua.ldb.stepIn()");
			return true;
		}

		bool cmdn(string tail)
		{
			if (!debugMode)
				return true;

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


		bool doCommand(string str)
		{
			string code;
			if (isControlCode(str,out code))
			{
				return doControlCode(code);
			}
			else 
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
						luaFunc.call(str);
					}
				}
				return false;
			}
		}
	}
}
