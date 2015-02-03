﻿
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out UnityEngine.UI.InputField.OnValidateInput ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            int r = LuaDLL.luaS_checkcallback(l, -1);
			if(r<0) LuaDLL.luaL_error(l,"expect function");
			if(getCacheDelegate<UnityEngine.UI.InputField.OnValidateInput>(r,out ua))
				return op;
			LuaDLL.lua_pop(l,1);
            ua = (string a1,int a2,System.Char a3) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				pushValue(l,a2);
				pushValue(l,a3);
				if (LuaDLL.lua_pcall(l, 3, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				System.Char ret;
				checkType(l,error+1,out ret);
				LuaDLL.lua_pop(l, 1);
				return ret;
			};
			cacheDelegate(r,ua);
			return op;
		}
	}
}
