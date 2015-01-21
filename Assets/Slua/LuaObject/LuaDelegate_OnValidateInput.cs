
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal bool checkDelegate(IntPtr l,int p,out UnityEngine.UI.InputField.OnValidateInput ua) {
            if(LuaDLL.lua_type(l,p)!=LuaTypes.LUA_TFUNCTION)
            {
                ua = null;
                return true;
            }
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = (string a1,int a2,Char a3) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				pushValue(l,a2);
				pushValue(l,a3);
				if (LuaDLL.lua_pcall(l, 3, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				int top =LuaDLL.lua_gettop(l);
				Char ret;
				checkType(l,error+1,out ret);
				LuaDLL.lua_pop(l, 1);
				return ret;
			};
			return true;
		}
	}
}
