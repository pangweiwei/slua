using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CameraClearFlags : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.CameraClearFlags o = (UnityEngine.CameraClearFlags)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CameraClearFlags");
		addMember(l,1,"Skybox");
		addMember(l,2,"Color");
		addMember(l,2,"SolidColor");
		addMember(l,3,"Depth");
		addMember(l,4,"Nothing");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
