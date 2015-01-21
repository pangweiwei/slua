using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_CompareFunction : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.Rendering.CompareFunction o = (UnityEngine.Rendering.CompareFunction)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.CompareFunction");
		addMember(l,0,"Disabled");
		addMember(l,1,"Never");
		addMember(l,2,"Less");
		addMember(l,3,"Equal");
		addMember(l,4,"LessEqual");
		addMember(l,5,"Greater");
		addMember(l,6,"NotEqual");
		addMember(l,7,"GreaterEqual");
		addMember(l,8,"Always");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
