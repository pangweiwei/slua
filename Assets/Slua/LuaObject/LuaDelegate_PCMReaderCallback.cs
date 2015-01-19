
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal bool checkDelegate(IntPtr l,int p,out UnityEngine.AudioClip.PCMReaderCallback ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = (float[] a1) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

                pushValue(l,a1);
                if (LuaDLL.lua_pcall(l, 1, 0, error) != 0)

                {
                    LuaDLL.lua_pop(l, 1); // pop error msg
                }
                LuaDLL.lua_pop(l, 1); // pop error function
            };
            return true;
        }   
    }
}

