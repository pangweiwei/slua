
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace SLua
{
    public partial class LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out UnityEngine.Canvas.WillRenderCanvases ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = (UnityEngine.Canvas.WillRenderCanvases)checkObj(l, p);
                return op;
            }
            LuaDelegate ld;
            checkType(l, -1, out ld);
            if(ld.d!=null)
            {
                ua = (UnityEngine.Canvas.WillRenderCanvases)ld.d;
                return op;
            }
			LuaDLL.lua_pop(l,1);
            ua = () =>
            {
                int error = pushTry(l);

				ld.call(0, error);
				LuaDLL.lua_settop(l, error-1);
			};
			ld.d=ua;
			return op;
		}
	}
}
