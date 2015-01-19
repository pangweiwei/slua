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
    public class LuaVar : IDisposable
    {
        protected IntPtr l = IntPtr.Zero;
        protected int valueref = 0;

        public LuaVar(IntPtr l, int r)
        {
            this.l = l;
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

            if (disposeManagedResources)
            {
                LuaDLL.lua_unref(l, valueref);
            }
        }
    }

    public class LuaFunction : LuaVar
    {

        public LuaFunction(IntPtr l, int r):base(l,r)
        {
            
        }

        public void call()
        {
            LuaDLL.lua_pushstdcallcfunction(l, LuaState.errorReport);
            int error = LuaDLL.lua_gettop(l);

            LuaDLL.lua_getref(l, valueref);
            if (!LuaDLL.lua_isfunction(l, -1))
            {
                LuaDLL.lua_pop(l, 1);
                throw new Exception("Not a function");
            }

            
            if (LuaDLL.lua_pcall(l, 0, LuaDLL.LUA_MULTRET, error) != 0)
            {
                LuaDLL.lua_pop(l, 1);
            }

            LuaDLL.lua_pop(l, 1); // pop error function
        }
        
    }





    class LuaState : IDisposable
    {
        static string WorkPath="./Assets/lua/";
        IntPtr L;

        public IntPtr handle
        {
            get { return L; }
        }

        public LuaState()
        {
            L = LuaDLL.luaL_newstate();
            LuaDLL.luaL_openlibs(L);

            ObjectCache.make(L);

            LuaDLL.lua_pushstdcallcfunction(L, print);
            LuaDLL.lua_setglobal(L, "print");

            LuaDLL.lua_pushstdcallcfunction(L, pcall);
            LuaDLL.lua_setglobal(L, "pcall");

            LuaDLL.lua_pushstdcallcfunction(L, loader);
            int loaderFunc = LuaDLL.lua_gettop(L);

            LuaDLL.lua_getglobal(L, "package");
#if !LUA_5_1
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

        ~LuaState()
        {
            //Unity destructor not call in main thread, so gc some unity object refed by lua will cause error when lua closed.
            //Close();
        }

        internal void Close()
        {
            if (L != IntPtr.Zero)
            {
                Debug.Log("Finalizing Lua State.");
                LuaDLL.lua_close(L);
            }
        }

        internal void dispose(int reference)
        {
            if (L != IntPtr.Zero) 
                LuaDLL.lua_unref(L, reference);
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
            fileName += ".lua";
            byte[] bytes = loadFile(fileName);
            LuaDLL.luaL_loadbuffer(L, bytes, bytes.Length, fileName);
            return 1;
        }

        public void doFile(string fn)
        {
            byte[] bytes = loadFile(fn);

            LuaDLL.lua_pushstdcallcfunction(L, errorReport);
            if (LuaDLL.luaL_loadbuffer(L, bytes, bytes.Length, fn) == 0)
            {
                if (LuaDLL.lua_pcall(L, 0, LuaDLL.LUA_MULTRET, -2) != 0)
                {
                    LuaDLL.lua_pop(L, 1);
                }
            }
        }

        static byte[] loadFile(string fn)
        {

            fn = WorkPath + fn;
            try
            {
                FileStream fs = File.Open(fn, FileMode.Open);
                long length = fs.Length;
                byte[] bytes = new byte[length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                return bytes;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public object get(string key)
        {
            LuaDLL.lua_getglobal(L, key);
            if (LuaDLL.lua_isnil(L, -1))
            {
                throw new Exception(string.Format("{0} not found", key));
            }

            LuaTypes type=LuaDLL.lua_type(L,-1);
            switch (type)
            {
                case LuaTypes.LUA_TNUMBER:
                    {
                        return LuaDLL.lua_tonumber(L, -1);
                    }
                case LuaTypes.LUA_TSTRING:
                    {
                        return LuaDLL.lua_tostring(L, -1);
                    }
                case LuaTypes.LUA_TBOOLEAN:
                    {
                        return LuaDLL.lua_toboolean(L, -1);
                    }
                case LuaTypes.LUA_TFUNCTION:
                    {
                        int r = LuaDLL.luaL_ref(L, LuaIndexes.LUA_REGISTRYINDEX);
                        LuaFunction v = new LuaFunction(L, r);
                        return v;
                    }
                default:
                    return null;
            }
            
        }

        public object this[string fullPath]
        {
            get
            {
                return get(fullPath);
            }
        }
    }

}
