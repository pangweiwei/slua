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

using System;
using System.Collections.Generic;
using System.Collections;
using LuaInterface;
using UnityEngine;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace SLua
{
	abstract public class LuaVar : IDisposable
	{
		protected LuaState state = null;
		protected int valueref = 0;



		public IntPtr L
		{
			get
			{
				return state.L;
			}
		}

		public int Ref
		{
			get
			{
				return valueref;
			}
		}

		public LuaVar()
		{
			state = null;
		}

		public LuaVar(LuaState l, int r)
		{
			state = l;
			valueref = r;
		}

		public LuaVar(IntPtr l, int r)
		{
			state = LuaState.get(l);
			valueref = r;
		}

		~LuaVar()
		{
			Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public virtual void Dispose(bool disposeManagedResources)
		{
			if (valueref != 0)
			{
				LuaState.UnRefAction act = (IntPtr l, int r) =>
				{
					LuaDLL.lua_unref(l, r);
				};
				state.gcRef(act, valueref);
				valueref = 0;
			}
		}

		public void push(IntPtr l)
		{
			LuaDLL.lua_getref(l, valueref);
		}
	}

	public class LuaDelegate : LuaFunction
	{
		public object d;

		public LuaDelegate(IntPtr l, int r)
			: base(l, r)
		{
		}

		public override void Dispose(bool disposeManagedResources)
		{
			if (valueref != 0)
			{
				LuaState.UnRefAction act = (IntPtr l, int r) =>
				{
					LuaObject.removeDelgate(l, r);
					LuaDLL.lua_unref(l, r);
				};
				state.gcRef(act, valueref);
				valueref = 0;
			}

		}
		
	}

	public class LuaFunction : LuaVar
	{
		public LuaFunction(LuaState l, int r)
			: base(l, r)
		{
		}

		public LuaFunction(IntPtr l, int r)
			: base(l, r)
		{
		}

		public bool call(int nArgs, int errfunc)
		{

			if (!state.isMainThread())
			{
				Debug.LogError("Can't call lua function in bg thread");
				return false;
			}

			LuaDLL.lua_getref(L, valueref);

			if (!LuaDLL.lua_isfunction(L, -1))
			{
				LuaDLL.lua_pop(L, 1);
				throw new Exception("Call invalid function.");
			}

			LuaDLL.lua_insert(L, -nArgs - 1);
			if (LuaDLL.lua_pcall(L, nArgs, -1, errfunc) != 0)
			{
				LuaDLL.lua_pop(L, 1);
				return false;
			}
			return true;
		}

		bool innerCall(int nArgs, int errfunc)
		{
			bool ret = call(nArgs, errfunc);
			LuaDLL.lua_remove(L, errfunc);
			return ret;
		}


		public object call()
		{
			int error=LuaObject.pushTry(state.L);
			if (innerCall(0, error))
			{
				return state.topObjects(error - 1);
			}
			return null;
		}

		public object call(params object[] args)
		{
			int error = LuaObject.pushTry(state.L);

			for (int n = 0; args!=null && n < args.Length; n++)
			{
				LuaObject.pushVar(L, args[n]);
			}

			if (innerCall(args != null ? args.Length : 0, error))
			{
				return state.topObjects(error - 1);
			}

			return null;
		}

		public object call(object a1)
		{
			int error=LuaObject.pushTry(state.L);

			LuaObject.pushVar(state.L,a1);
			if (innerCall(1, error))
			{
				return state.topObjects(error - 1);
			}
			

			return null;
		}

		public object call(object a1,object a2)
		{
			int error = LuaObject.pushTry(state.L);

			LuaObject.pushVar(state.L, a1);
			LuaObject.pushVar(state.L, a2);
			if (innerCall(2, error))
			{
				return state.topObjects(error - 1);
			}
			return null;
		}

		public object call(object a1,object a2,object a3)
		{
			int error = LuaObject.pushTry(state.L);

			LuaObject.pushVar(state.L, a1);
			LuaObject.pushVar(state.L, a2);
			LuaObject.pushVar(state.L, a3);
			if (innerCall(3, error))
			{
				return state.topObjects(error - 1);
			}
			return null;
		}

	}

	public class LuaTable : LuaVar, IEnumerable<LuaTable.TablePair>
	{


		public struct TablePair
		{
			public object key;
			public object value;
		}
		public LuaTable(IntPtr l, int r)
			: base(l, r)
		{
		}

		public LuaTable(LuaState l, int r)
			: base(l, r)
		{
		}

		public LuaTable(LuaState state)
			: base(state, 0)
		{

			LuaDLL.lua_newtable(L);
			valueref = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
		}
		public object this[string key]
		{
			get
			{
				return state.getObject(valueref, key);
			}

			set
			{
				state.setObject(valueref, key, value);
			}
		}

		public object this[int index]
		{
			get
			{
				return state.getObject(valueref, index);
			}

			set
			{
				state.setObject(valueref, index, value);
			}
		}

		public object invoke(string func,params object[] args)
		{
			LuaFunction f = (LuaFunction)this[func];
			if (f != null)
			{
				return f.call(args);
			}
			throw new Exception(string.Format("Can't find {0} function", func));
		}

		public class Enumerator : IEnumerator<TablePair>, IDisposable
		{
			LuaTable t;
			int indext = -1;
			TablePair current = new TablePair();
			int iterPhase = 0;

			public Enumerator(LuaTable table)
			{
				t = table;
				Reset();
			}

			public bool MoveNext()
			{
				if (indext < 0)
					return false;

				if (iterPhase==0)
				{
					LuaDLL.lua_pushnil(t.L);
					iterPhase = 1;
				}
				else
					LuaDLL.lua_pop(t.L, 1);

				bool ret = LuaDLL.lua_next(t.L, indext) > 0;
				if(!ret) iterPhase=2;

				return ret;
			}

			public void Reset()
			{
				LuaDLL.lua_getref(t.L, t.Ref);
				indext = LuaDLL.lua_gettop(t.L);
			}

			public void Dispose()
			{
				if(iterPhase==1)
					LuaDLL.lua_pop(t.L, 1);

				LuaDLL.lua_remove(t.L, indext);
			}

			public TablePair Current
			{
				get
				{
					current.key = LuaObject.checkVar(t.L, -2);
					current.value = LuaObject.checkVar(t.L, -1);
					return current;
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return Current;
				}
			}
		}

		public IEnumerator<TablePair> GetEnumerator()
		{
			return new LuaTable.Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

	}





	public class LuaState : IDisposable
	{
		IntPtr l_;
		int mainThread = 0;
		internal WeakDictionary<int, LuaDelegate> delgateMap = new WeakDictionary<int, LuaDelegate>();

		public IntPtr L
		{
			get
			{

				if (!isMainThread())
				{
					throw new Exception("Can't access lua in bg thread");
				}

				if (l_ == IntPtr.Zero)
					throw new Exception("LuaState had been destroyed, can't used yet");

				return l_;
			}
			set
			{
				l_ = value;
			}
		}

		public IntPtr handle
		{
			get
			{
				return L;
			}
		}

		public delegate byte[] LoaderDelegate(string fn);
		static public LoaderDelegate loaderDelegate;


		public delegate void UnRefAction(IntPtr l, int r);
		struct UnrefPair
		{
			public UnRefAction act;
			public int r;
		}
		Queue<UnrefPair> refQueue;


		public static LuaState main;
		static Dictionary<IntPtr, LuaState> statemap = new Dictionary<IntPtr, LuaState>();
		static IntPtr oldptr = IntPtr.Zero;
		static LuaState oldstate = null;
		static public LuaCSFunction errorFunc = new LuaCSFunction(errorReport);

		public bool isMainThread()
		{
			return System.Threading.Thread.CurrentThread.ManagedThreadId == mainThread;
		}

		static public LuaState get(IntPtr l)
		{
			if (l == oldptr)
				return oldstate;

			LuaState ls;
			if (statemap.TryGetValue(l, out ls))
			{
				oldptr = l;
				oldstate = ls;
				return ls;
			}

			LuaDLL.lua_getglobal(l, "__main_state");
			if (LuaDLL.lua_isnil(l, -1))
			{
				LuaDLL.lua_pop(l, 1);
				return null;
			}

			IntPtr nl = LuaDLL.lua_touserdata(l, -1);
			LuaDLL.lua_pop(l, 1);
			if (nl != l)
				return get(nl);
			return null;
		}

		public LuaState()
		{
			mainThread = System.Threading.Thread.CurrentThread.ManagedThreadId;

			L = LuaDLL.luaL_newstate();
			statemap[L] = this;
			if (main == null) main = this;

			refQueue = new Queue<UnrefPair>();

			LuaDLL.luaL_openlibs(L);

			ObjectCache.make(L);

			LuaDLL.lua_pushlightuserdata(L, L);
			LuaDLL.lua_setglobal(L, "__main_state");

			LuaDLL.lua_pushcfunction(L, print);
			LuaDLL.lua_setglobal(L, "print");

			LuaDLL.lua_pushcfunction(L, pcall);
			LuaDLL.lua_setglobal(L, "pcall");

			LuaDLL.lua_pushcfunction(L, import);
			LuaDLL.lua_setglobal(L, "import");

			string resumefunc = @"
local resume = coroutine.resume
coroutine.resume=function(co,...)
	local ok,err=resume(co,...)
	if not ok then 	UnityEngine.Debug.LogError(debug.traceback(co,err)) end
end
";
			// overload resume function for report error
			if(LuaDLL.lua_dostring(L, resumefunc)!=0)
				LuaObject.throwLuaError(L);

			LuaDLL.lua_pushcfunction(L, dofile);
			LuaDLL.lua_setglobal(L, "dofile");

			LuaDLL.lua_pushcfunction(L, loadfile);
			LuaDLL.lua_setglobal(L, "loadfile");

			LuaDLL.lua_pushcfunction(L, loader);
			int loaderFunc = LuaDLL.lua_gettop(L);

			LuaDLL.lua_getglobal(L, "package");
#if LUA_5_3
			LuaDLL.lua_getfield(L, -1, "searchers");
#else
			LuaDLL.lua_getfield(L, -1, "loaders");
#endif
			int loaderTable = LuaDLL.lua_gettop(L);

			// Shift table elements right
			for (int e = LuaDLL.lua_rawlen(L, loaderTable) + 1; e > 1; e--)
			{
				LuaDLL.lua_rawgeti(L, loaderTable, e - 1);
				LuaDLL.lua_rawseti(L, loaderTable, e);
			}
			LuaDLL.lua_pushvalue(L, loaderFunc);
			LuaDLL.lua_rawseti(L, loaderTable, 1);
			LuaDLL.lua_settop(L, 0);
		}

		public void Close()
		{
			if (L != IntPtr.Zero)
			{
				if (LuaState.main == this)
					LuaState.main = null;

				Debug.Log("Finalizing Lua State.");
				// be careful, if you close lua vm, make sure you don't use lua state again,
				// comment this line as default for avoid unexpected crash.
				// LuaDLL.lua_close(L);
				// L = IntPtr.Zero;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			ObjectCache.del(L);
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
		}

		public virtual void Dispose(bool dispose)
		{
			if (dispose)
			{
				Close();
			}
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		public static int errorReport(IntPtr L)
		{
			LuaDLL.lua_getglobal(L, "debug");
			LuaDLL.lua_getfield(L, -1, "traceback");
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.lua_pushnumber(L, 2);
			LuaDLL.lua_call(L, 2, 1);
			LuaDLL.lua_remove(L, -2);
			Debug.LogError(LuaDLL.lua_tostring(L, -1));
			LuaDLL.lua_pop(L, 1);
			return 0;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		internal static int import(IntPtr l)
		{
			LuaDLL.luaL_checktype(l, 1, LuaTypes.LUA_TSTRING);
			string str = LuaDLL.lua_tostring(l, 1);

			string[] ns = str.Split('.');

			LuaDLL.lua_pushglobaltable(l);

			for (int n = 0; n < ns.Length; n++)
			{
				LuaDLL.lua_getfield(l, -1, ns[n]);
				if (!LuaDLL.lua_istable(l, -1))
				{
					LuaDLL.luaL_error(l, "expect {0} is type table", ns);
					return 0;
				}
				LuaDLL.lua_remove(l, -2);
			}

			LuaDLL.lua_pushnil(l);
			while (LuaDLL.lua_next(l, -2) != 0)
			{
				string key = LuaDLL.lua_tostring(l, -2);
				LuaDLL.lua_getglobal(l, key);
				if (!LuaDLL.lua_isnil(l, -1))
				{
					LuaDLL.lua_pop(l, 1);
					LuaDLL.luaL_error(l, "{0} had existed, import can't overload it.", key);
					return 0;
				}
				LuaDLL.lua_pop(l, 1);
				LuaDLL.lua_setglobal(l, key);
			}

			LuaDLL.lua_pop(l, 1);

			return 0;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		internal static int pcall(IntPtr L)
		{
			int status;
			LuaDLL.luaL_checktype(L, 1, LuaTypes.LUA_TFUNCTION);
			status = LuaDLL.lua_pcall(L, LuaDLL.lua_gettop(L) - 1, LuaDLL.LUA_MULTRET, 0);
			LuaDLL.lua_pushboolean(L, (status == 0));
			LuaDLL.lua_insert(L, 1);
			return LuaDLL.lua_gettop(L);  /* return status + all results */
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		internal static int print(IntPtr L)
		{
			int n = LuaDLL.lua_gettop(L);
			string s = "";

			LuaDLL.lua_getglobal(L, "tostring");

			for (int i = 1; i <= n; i++)
			{
				if (i > 1)
				{
					s += "    ";
				}

				LuaDLL.lua_pushvalue(L, -1);
				LuaDLL.lua_pushvalue(L, i);

				LuaDLL.lua_call(L, 1, 1);
				s += LuaDLL.lua_tostring(L, -1);
				LuaDLL.lua_pop(L, 1);
			}
			LuaDLL.lua_settop(L, n);
			Debug.Log(s);
			return 0;
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		internal static int loadfile(IntPtr L)
		{
			return loader(L);
		}

		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		internal static int dofile(IntPtr L)
		{
			int n = LuaDLL.lua_gettop(L);

			if (loader(L) != 0) return LuaDLL.lua_gettop(L) - n;

			LuaDLL.lua_call(L, 0, LuaDLL.LUA_MULTRET);
			return LuaDLL.lua_gettop(L) - n;
		}
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
		internal static int loader(IntPtr L)
		{
			string fileName = LuaDLL.lua_tostring(L, 1);
			byte[] bytes = loadFile(fileName);
			if (bytes != null)
			{
				LuaDLL.luaL_loadbuffer(L, bytes, bytes.Length, fileName);
				return 1;
			}
			return 0;
		}

		public object doString(string str)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(str);

			object obj;
			if (doBuffer(bytes, "temp buffer", out obj))
				return obj;
			return null; ;

		}

		public object doFile(string fn)
		{
			byte[] bytes = loadFile(fn);
			if (bytes == null)
			{
				Debug.LogError(string.Format("Can't find {0}", fn));
				return null;
			}

			object obj;
			if (doBuffer(bytes, fn, out obj))
				return obj;
			return null;
		}

		public bool doBuffer(byte[] bytes, string fn, out object ret)
		{
			ret = null;
			LuaDLL.lua_pushcfunction(L, errorFunc);
			int errfunc = LuaDLL.lua_gettop(L);
			if (LuaDLL.luaL_loadbuffer(L, bytes, bytes.Length, fn) == 0)
			{
				if (LuaDLL.lua_pcall(L, 0, LuaDLL.LUA_MULTRET, -2) != 0)
				{
					LuaDLL.lua_pop(L, 1);
					return false;
				}
				LuaDLL.lua_remove(L, errfunc); // pop error function
				ret = topObjects(errfunc - 1);
				return true;
			}
			string err = LuaDLL.lua_tostring(L, -1);
			Debug.LogError(err);
			LuaDLL.lua_pop(L, 1);
			return false;
		}

		static byte[] loadFile(string fn)
		{
			try
			{
				byte[] bytes;
				if (loaderDelegate != null)
					bytes = loaderDelegate(fn);
				else
				{
					fn = fn.Replace(".", "/");
					TextAsset asset = (TextAsset)Resources.Load(fn);
					if (asset != null)
						return asset.bytes;
					return null;
				}
				return bytes;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}


		internal object getObject(string key)
		{
			LuaDLL.lua_pushglobaltable(L);
			object o = getObject(key.Split(new char[] { '.' }));
			LuaDLL.lua_pop(L, 1);
			return o;
		}

		internal void setObject(string key, object v)
		{
			LuaDLL.lua_pushglobaltable(L);
			setObject(key.Split(new char[] { '.' }), v);
			LuaDLL.lua_pop(L, 1);
		}

		internal object getObject(string[] remainingPath)
		{
			object returnValue = null;
			for (int i = 0; i < remainingPath.Length; i++)
			{
				LuaDLL.lua_pushstring(L, remainingPath[i]);
				LuaDLL.lua_gettable(L, -2);
				returnValue = this.getObject(L, -1);
				LuaDLL.lua_remove(L, -2);
				if (returnValue == null) break;
			}
			return returnValue;
		}


		internal object getObject(int reference, string field)
		{
			int oldTop = LuaDLL.lua_gettop(L);
			LuaDLL.lua_getref(L, reference);
			object returnValue = getObject(field.Split(new char[] { '.' }));
			LuaDLL.lua_settop(L, oldTop);
			return returnValue;
		}

		internal object getObject(int reference, int index)
		{
			if (index >= 1)
			{
				int oldTop = LuaDLL.lua_gettop(L);
				LuaDLL.lua_getref(L, reference);
				LuaDLL.lua_rawgeti(L, -1, index);
				object returnValue = LuaObject.checkVar(L, -1);
				LuaDLL.lua_settop(L, oldTop);
				return returnValue;
			}
			throw new IndexOutOfRangeException();
		}

		internal object getObject(int reference, object field)
		{
			int oldTop = LuaDLL.lua_gettop(L);
			LuaDLL.lua_getref(L, reference);
			LuaObject.pushObject(L, field);
			LuaDLL.lua_gettable(L, -2);
			object returnValue = getObject(L, -1);
			LuaDLL.lua_settop(L, oldTop);
			return returnValue;
		}

		internal void setObject(string[] remainingPath, object o)
		{
			int top = LuaDLL.lua_gettop(L);
			for (int i = 0; i < remainingPath.Length - 1; i++)
			{
				LuaDLL.lua_pushstring(L, remainingPath[i]);
				LuaDLL.lua_gettable(L, -2);
			}
			LuaDLL.lua_pushstring(L, remainingPath[remainingPath.Length - 1]);
			LuaObject.pushVar(L, o);
			LuaDLL.lua_settable(L, -3);
			LuaDLL.lua_settop(L, top);
		}


		internal void setObject(int reference, string field, object o)
		{
			int oldTop = LuaDLL.lua_gettop(L);
			LuaDLL.lua_getref(L, reference);
			setObject(field.Split(new char[] { '.' }), o);
			LuaDLL.lua_settop(L, oldTop);
		}

		internal void setObject(int reference, int index, object o)
		{
			if (index >= 1)
			{
				int oldTop = LuaDLL.lua_gettop(L);
				LuaDLL.lua_getref(L, reference);
				LuaObject.pushVar(L, o);
				LuaDLL.lua_rawseti(L, -2, index);
				LuaDLL.lua_settop(L, oldTop);
				return;
			}
			throw new IndexOutOfRangeException();
		}

		internal void setObject(int reference, object field, object o)
		{
			int oldTop = LuaDLL.lua_gettop(L);
			LuaDLL.lua_getref(L, reference);
			LuaObject.pushObject(L, field);
			LuaObject.pushObject(L, o);
			LuaDLL.lua_settable(L, -3);
			LuaDLL.lua_settop(L, oldTop);
		}

		internal object topObjects(int from)
		{
			int top = LuaDLL.lua_gettop(L);
			int nArgs = top - from;
			if (nArgs == 0)
				return null;
			else if (nArgs == 1)
			{
				object o = LuaObject.checkVar(L, top);
				LuaDLL.lua_pop(L, 1);
				return o;
			}
			else
			{
				object[] o = new object[nArgs];
				for (int n = 1; n <= nArgs; n++)
				{
					o[n - 1] = LuaObject.checkVar(L, from + n);

				}
				LuaDLL.lua_settop(L, from);
				return o;
			}
		}

		object getObject(IntPtr l, int p)
		{
			return LuaObject.checkVar(l, p);
		}

		public LuaFunction getFunction(string key)
		{
			return (LuaFunction)this[key];
		}

		public LuaTable getTable(string key)
		{
			return (LuaTable)this[key];
		}


		public object this[string path]
		{
			get
			{
				return this.getObject(path);
			}
			set
			{
				this.setObject(path, value);
			}
		}

		public void gcRef(UnRefAction act, int r)
		{
			lock (refQueue)
			{
				UnrefPair u = new UnrefPair();
				u.act = act;
				u.r = r;
				refQueue.Enqueue(u);
			}
		}

		public void checkRef()
		{
			while (refQueue.Count > 0)
			{
				UnrefPair u;
				lock (refQueue)
				{
					u = refQueue.Dequeue();
				}
				u.act(L, u.r);
			}
		}
	}
}
