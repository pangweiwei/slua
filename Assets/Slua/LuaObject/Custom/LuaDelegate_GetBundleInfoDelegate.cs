
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out HelloWorld.GetBundleInfoDelegate ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            int r = LuaDLL.luaS_checkcallback(l, -1);
			if(r<0) LuaDLL.luaL_error(l,"expect function");
			if(getCacheDelegate<HelloWorld.GetBundleInfoDelegate>(r,out ua))
				return op;
			LuaDLL.lua_pop(l,1);
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
			cacheDelegate(r,ua);
			return op;
		}
	}
}
