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
using LuaInterface;
using UnityEngine;
using System.IO;

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
            if (valueref!=0)
            {
                // move unref to luastate thread
                state.gcRef(valueref);
                valueref = 0;
            }
        }

        public void push(IntPtr l)
        {
            LuaDLL.lua_getref(l, valueref);
        }
    }

    public class LuaFunction : LuaVar
    {
        public LuaFunction(LuaState l, int r):base(l,r)
        {
        }

        public LuaFunction(IntPtr l, int r):base(l,r)
        {
        }


        public void call()
        {
            LuaDLL.lua_pushstdcallcfunction(L, LuaState.errorReport);
			int error = LuaDLL.lua_gettop(L);

			LuaDLL.lua_getref(L, valueref);
			if (!LuaDLL.lua_isfunction(L, -1))
            {
				LuaDLL.lua_pop(L, 1);
                throw new Exception("Not a function");
            }


			if (LuaDLL.lua_pcall(L, 0, 0, error) != 0)
            {
				LuaDLL.lua_pop(L, 1);
            }

			LuaDLL.lua_remove(L, error); // pop error function
        }

        public object call(params object[] args)
        {
			LuaDLL.lua_pushstdcallcfunction(L, LuaState.errorReport);
			int error = LuaDLL.lua_gettop(L);
            if (error != 1)
                Debug.Log("Some function push more value to lua stack");

			LuaDLL.lua_getref(L, valueref);
			if (!LuaDLL.lua_isfunction(L, -1))
            {
				LuaDLL.lua_pop(L, 1);
                throw new Exception("Not a function");
            }

            for (int n = 0; n < args.Length; n++)
            {
				LuaObject.pushVar(L, args[n]);
            }

			if (LuaDLL.lua_pcall(L, args.Length, LuaDLL.LUA_MULTRET, error) != 0)
            {
				LuaDLL.lua_pop(L, 1);
            }

			LuaDLL.lua_remove(L, error); // pop error function

			return state.topObjects();
        }
        
    }

    public class LuaTable : LuaVar
    {
        public LuaTable(IntPtr l, int r)
            : base(l, r)
        {
        }

        public LuaTable(LuaState l, int r)
            : base(l, r)
        {
        }

        public LuaTable(LuaState state):base(state,0)
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
    }





    public class LuaState : IDisposable
    {
        IntPtr l_;
		public IntPtr L {
			get {
				if(l_==IntPtr.Zero) 
					throw new Exception("LuaState had been destroyed, can't used yet");
				return l_;
			}
			set {
				l_ = value;
			}
		}

		public IntPtr handle {
			get {
				return L;
			}
		}

        public delegate byte[] LoaderDelegate(string fn);
        static public LoaderDelegate loaderDelegate;

        Queue<int> refQueue;


        public static LuaState main;
        static Dictionary<IntPtr, LuaState> statemap = new Dictionary<IntPtr, LuaState>();

        static public LuaState get(IntPtr l)
        {
            return statemap[l];
        }

        public LuaState()
        {
            L = LuaDLL.luaL_newstate();
            statemap[L] = this;
            if (main == null) main = this;

            refQueue = new Queue<int>();

            LuaDLL.luaL_openlibs(L);

            ObjectCache.make(L);

            LuaDLL.lua_pushstdcallcfunction(L, print);
            LuaDLL.lua_setglobal(L, "print");

            LuaDLL.lua_pushstdcallcfunction(L, pcall);
            LuaDLL.lua_setglobal(L, "pcall");

            LuaDLL.lua_pushstdcallcfunction(L, loader);
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

        internal void Close()
        {
            if (L != IntPtr.Zero)
            {
                Debug.Log("Finalizing Lua State.");
				// be careful, if you close lua vm, make sure you don't use lua state again,
				// comment this line as default for avoid unexpected crash.
                // LuaDLL.lua_close(L);
                L = IntPtr.Zero;
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
        internal static int loader(IntPtr L)
        {
            string fileName = LuaDLL.lua_tostring(L, 1);
            byte[] bytes = loadFile(fileName);
			if(bytes!=null) {
            	LuaDLL.luaL_loadbuffer(L, bytes, bytes.Length, fileName);
            	return 1;
			}
			return 0;
        }

        public object doFile(string fn)
        {
            byte[] bytes = loadFile(fn);
			if(bytes==null) {
				Debug.LogError(string.Format("Can't find {0}",fn));
				return null;
			}

            LuaDLL.lua_pushstdcallcfunction(L, errorReport);
			int errfunc = LuaDLL.lua_gettop(L);
            if (LuaDLL.luaL_loadbuffer(L, bytes, bytes.Length, fn) == 0)
            {
                if (LuaDLL.lua_pcall(L, 0, LuaDLL.LUA_MULTRET, -2) != 0)
                {
                    LuaDLL.lua_pop(L, 1);
                }
                LuaDLL.lua_remove(L, errfunc); // pop error function
				return topObjects();
            }
            else
            {
                string err = LuaDLL.lua_tostring(L, -1);
                Debug.LogError(err);
                LuaDLL.lua_pop(L, 1);
            }
			return null;
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
					fn=fn.Replace(".","/");
					TextAsset asset=(TextAsset) Resources.Load(fn);
					return asset.bytes;
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
            setObject(key.Split(new char[] { '.' }),v);
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
                LuaDLL.lua_pop(L, 1);
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
            for (int i = 0; i < remainingPath.Length - 1; i++)
            {
                LuaDLL.lua_pushstring(L, remainingPath[i]);
                LuaDLL.lua_gettable(L, -2);
            }
            LuaDLL.lua_pushstring(L, remainingPath[remainingPath.Length - 1]);
            LuaObject.pushVar(L, o);
            LuaDLL.lua_settable(L, -3);
        }

       
        internal void setObject(int reference, string field, object o)
        {
            int oldTop = LuaDLL.lua_gettop(L);
            LuaDLL.lua_getref(L, reference);
            setObject(field.Split(new char[] { '.' }), o);
            LuaDLL.lua_settop(L, oldTop);
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

		internal object topObjects() 
		{
			int top = LuaDLL.lua_gettop(L);
			if (top == 0)
				return null;
			else if (top == 1)
			{
				object o = LuaObject.checkVar(L, 1);
				LuaDLL.lua_pop(L, 1);
				return o;
			}
			else
			{
				object[] o = new object[top];
				for (int n = 1; n <= top; n++)
				{
					o[n - 1] = LuaObject.checkVar(L, n);
					
				}
				LuaDLL.lua_pop(L, top);
				return o;
			}
		}
			
			object getObject(IntPtr l, int p)
			{
				return LuaObject.checkVar(l,p);
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

        public void gcRef(int r)
        {
            lock (refQueue)
            {
                refQueue.Enqueue(r);    
            }
        }

        public void checkRef()
        {
            while( refQueue.Count> 0 ) {
                int r;
                lock (refQueue)
                {
                    r = refQueue.Dequeue();
                }
				LuaDLL.lua_unref(L, r);
            }
        }
    }
}
