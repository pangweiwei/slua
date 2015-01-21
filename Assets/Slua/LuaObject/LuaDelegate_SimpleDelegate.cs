
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal bool checkDelegate(IntPtr l,int p,out HelloWorld.SimpleDelegate ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = (string a1,GameObject a2) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				pushValue(l,a2);
				if (LuaDLL.lua_pcall(l, 2, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				int top =LuaDLL.lua_gettop(l);
				LuaDLL.lua_pop(l, 1);
			};
			return true;
		}
	}
}
