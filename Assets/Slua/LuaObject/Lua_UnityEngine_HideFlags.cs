using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HideFlags : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.HideFlags o = (UnityEngine.HideFlags)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.HideFlags");
		addMember(l,0,"None");
		addMember(l,1,"HideInHierarchy");
		addMember(l,2,"HideInInspector");
		addMember(l,4,"DontSave");
		addMember(l,8,"NotEditable");
		addMember(l,13,"HideAndDontSave");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
