
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal bool checkDelegate(IntPtr l,int p,out HelloWorld.GetBundleInfoDelegate ua) {
            if(LuaDLL.lua_type(l,p)!=LuaTypes.LUA_TFUNCTION)
            {
                ua = null;
                return true;
            }
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = (string a1,out string a2,out int a3,out UInt32 a4,ref int a5) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				pushValue(l,a5);
				if (LuaDLL.lua_pcall(l, 2, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				int top =LuaDLL.lua_gettop(l);
				bool ret;
				checkType(l,error+1,out ret);
				checkType(l,error+2,out a2);
				checkType(l,error+3,out a3);
				checkType(l,error+4,out a4);
				checkType(l,error+5,out a5);
				LuaDLL.lua_pop(l, 1);
				return ret;
			};
			return true;
		}
	}
}
