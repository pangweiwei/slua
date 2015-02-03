
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out UIWidget.OnPostFillCallback ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            int r = LuaDLL.luaS_checkcallback(l, -1);
			if(r<0) LuaDLL.luaL_error(l,"expect function");
			if(getCacheDelegate<UIWidget.OnPostFillCallback>(r,out ua))
				return op;
			LuaDLL.lua_pop(l,1);
            ua = (UIWidget a1,int a2,BetterList<UnityEngine.Vector3> a3,BetterList<UnityEngine.Vector2> a4,BetterList<UnityEngine.Color32> a5) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				pushValue(l,a2);
				pushValue(l,a3);
				pushValue(l,a4);
				pushValue(l,a5);
				if (LuaDLL.lua_pcall(l, 5, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				LuaDLL.lua_pop(l, 1);
			};
			cacheDelegate(r,ua);
			return op;
		}
	}
}
