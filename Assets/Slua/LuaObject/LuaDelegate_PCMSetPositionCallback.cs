
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal bool checkDelegate(IntPtr l,int p,out UnityEngine.AudioClip.PCMSetPositionCallback ua) {
            if(LuaDLL.lua_type(l,p)!=LuaTypes.LUA_TFUNCTION)
            {
                ua = null;
                return true;
            }
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = (int a1) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				if (LuaDLL.lua_pcall(l, 1, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				int top =LuaDLL.lua_gettop(l);
				LuaDLL.lua_pop(l, 1);
			};
			return true;
		}
	}
}
