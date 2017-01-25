using System;
using System.Collections;

namespace SLua
{
    using UnityEngine;

    public class LuaThreadWrapper : LuaVar
    {
        private IntPtr _thread;
        
        public LuaThreadWrapper(LuaFunction func)
         : base()
        {
            Debug.LogFormat("LuaThreadWrapper.ctor/1: {0}", LuaDLL.lua_gettop(func.L));
            state = LuaState.get(func.L); // why do not give access of state?
            _thread = LuaDLL.lua_newthread(func.L);
            valueref = LuaDLL.luaL_ref(func.L, LuaIndexes.LUA_REGISTRYINDEX);
            func.push(func.L);
            LuaDLL.lua_xmove(func.L, _thread, 1);
            Debug.LogFormat("LuaThreadWrapper.ctor/2: {0}", LuaDLL.lua_gettop(func.L));
        }

        ~LuaThreadWrapper()
        {
            Debug.Log("~LuaThreadWrapper");
            Dispose(false);
        }

		public override void Dispose(bool disposeManagedResources)
        {
            base.Dispose(disposeManagedResources);
            _thread = IntPtr.Zero;
        }

        public bool EqualsTo(IntPtr L)
        {
            return _thread == L;
        }

        private object TopObjects(int nArgs)
        {
            if (nArgs == 0)
                return null;
            else if (nArgs == 1)
            {
                object o = LuaObject.checkVar(_thread, -1);
                return o;
            }
            else
            {
                object[] o = new object[nArgs];
                for (int n = 1; n <= nArgs; n++)
                {
                    o[n - 1] = LuaObject.checkVar(_thread, n);
                }
                return o;
            }
        }

        /// 返回true继续执行, false无法继续执行
        public bool Resume(out object retVal)
        {
            if (_thread == IntPtr.Zero)
            {
                SLua.Logger.LogError("thread: already disposed?");
                retVal = null;
                return false;
            }
            var status = LuaDLL.lua_status(_thread); // LUA_OK = 0
            if (status != 0 && status != (int)LuaThreadStatus.LUA_YIELD)
            {
                SLua.Logger.LogError("thread: wrong status ?= " + status);
                retVal = null;
                return false;
            }
            //var debug_top = LuaDLL.lua_gettop(_thread);
            var result = LuaDLL.lua_resume(_thread, 0);
            if (result != (int)LuaThreadStatus.LUA_YIELD)
            {
                if (result != 0)
                {
                    string error = LuaDLL.lua_tostring(_thread, -1);
                    SLua.Logger.LogError(string.Format("wrong result ?= {0} err: {1}", result, error));
                }
                retVal = null;
                return false;
            }
            var nArgsFromYield = LuaDLL.lua_gettop(_thread);
            //Debug.LogFormat("thread debug {0} {1}", debug_top, nArgsFromYield);
            retVal = TopObjects(nArgsFromYield); //?? top is thread self, but remove after yield??
            return true;
        }
    }
}
