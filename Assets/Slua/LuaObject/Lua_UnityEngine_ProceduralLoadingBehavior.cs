using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralLoadingBehavior : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ProceduralLoadingBehavior o = (UnityEngine.ProceduralLoadingBehavior)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ProceduralLoadingBehavior");
		addMember(l,0,"DoNothing");
		addMember(l,1,"Generate");
		addMember(l,2,"BakeAndKeep");
		addMember(l,3,"BakeAndDiscard");
		addMember(l,4,"Cache");
		addMember(l,5,"DoNothingAndCache");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
