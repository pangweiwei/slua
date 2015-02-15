
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out System.Func<UnityEngine.UI.ILayoutElement,System.Single> ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = (System.Func<UnityEngine.UI.ILayoutElement,System.Single>)checkObj(l, p);
                return op;
            }
            LuaDelegate ld;
            checkType(l, -1, out ld);
            if(ld.d!=null)
            {
                ua = (System.Func<UnityEngine.UI.ILayoutElement,System.Single>)ld.d;
                return op;
            }
			LuaDLL.lua_pop(l,1);
            ua = (UnityEngine.UI.ILayoutElement a1) =>
            {
                int error = pushTry(l);

				pushValue(l,a1);
				ld.call(1, error);
				float ret;
				checkType(l,error+1,out ret);
				LuaDLL.lua_settop(l, error-1);
				return ret;
			};
			ld.d=ua;
			return op;
		}
	}
}
