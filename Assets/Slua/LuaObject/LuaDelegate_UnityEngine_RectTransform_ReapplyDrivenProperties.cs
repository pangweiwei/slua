﻿
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out UnityEngine.RectTransform.ReapplyDrivenProperties ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = (UnityEngine.RectTransform.ReapplyDrivenProperties)checkObj(l, p);
                return op;
            }
            int r = LuaDLL.luaS_checkcallback(l, -1);
			if(r<0) LuaDLL.luaL_error(l,"expect function");
			if(getCacheDelegate<UnityEngine.RectTransform.ReapplyDrivenProperties>(r,out ua))
				return op;
			LuaDLL.lua_pop(l,1);
            ua = (UnityEngine.RectTransform a1) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				if (LuaDLL.lua_pcall(l, 1, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				LuaDLL.lua_settop(l, error-1);
			};
			cacheDelegate(r,ua);
			return op;
		}
	}
}
