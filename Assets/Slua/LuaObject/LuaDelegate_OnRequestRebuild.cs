
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal bool checkDelegate(IntPtr l,int p,out UnityEngine.CanvasRenderer.OnRequestRebuild ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = () =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

                if (LuaDLL.lua_pcall(l, 0, 0, error) != 0)

                {
                    LuaDLL.lua_pop(l, 1); // pop error msg
                }
                LuaDLL.lua_pop(l, 1); // pop error function
            };
            return true;
        }   
    }
}

