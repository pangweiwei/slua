
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out Deleg.GetBundleInfoDelegate ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            int r = LuaDLL.luaS_checkcallback(l, -1);
			if(r<0) LuaDLL.luaL_error(l,"expect function");
			if(getCacheDelegate<Deleg.GetBundleInfoDelegate>(r,out ua))
				return op;
			LuaDLL.lua_pop(l,1);
            ua = (string a1,out System.String a2,out System.Int32 a3) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				pushValue(l,a1);
				if (LuaDLL.lua_pcall(l, 1, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				bool ret;
				checkType(l,error+1,out ret);
				checkType(l,error+2,out a2);
				checkType(l,error+3,out a3);
				LuaDLL.lua_settop(l, error-1);
				return ret;
			};
			cacheDelegate(r,ua);
			return op;
		}
	}
}
