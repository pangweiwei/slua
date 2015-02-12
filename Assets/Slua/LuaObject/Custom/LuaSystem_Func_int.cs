
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out System.Func<System.Int32> ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = (System.Func<System.Int32>)checkObj(l, p);
                return op;
            }
            int r = LuaDLL.luaS_checkcallback(l, -1);
			if(r<0) LuaDLL.luaL_error(l,"expect function");
			if(getCacheDelegate<System.Func<System.Int32>>(r,out ua))
				return op;
			LuaDLL.lua_pop(l,1);
            ua = () =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);

				if (LuaDLL.lua_pcall(l, 0, -1, error) != 0) {
					LuaDLL.lua_pop(l, 1);
				}
				int ret;
				checkType(l,error+1,out ret);
				LuaDLL.lua_settop(l, error-1);
				return ret;
			};
			cacheDelegate(r,ua);
			return op;
		}
	}
}
