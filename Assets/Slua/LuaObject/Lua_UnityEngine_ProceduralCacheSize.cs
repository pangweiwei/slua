using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralCacheSize : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ProceduralCacheSize o = (UnityEngine.ProceduralCacheSize)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ProceduralCacheSize");
		addMember(l,0,"Tiny");
		addMember(l,1,"Medium");
		addMember(l,2,"Heavy");
		addMember(l,3,"NoLimit");
		addMember(l,4,"None");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
