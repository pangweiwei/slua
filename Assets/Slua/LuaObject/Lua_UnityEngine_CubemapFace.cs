using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CubemapFace : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.CubemapFace o = (UnityEngine.CubemapFace)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CubemapFace");
		addMember(l,0,"PositiveX");
		addMember(l,1,"NegativeX");
		addMember(l,2,"PositiveY");
		addMember(l,3,"NegativeY");
		addMember(l,4,"PositiveZ");
		addMember(l,5,"NegativeZ");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
