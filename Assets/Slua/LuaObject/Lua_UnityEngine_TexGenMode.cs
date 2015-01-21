using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TexGenMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.TexGenMode o = (UnityEngine.TexGenMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TexGenMode");
		addMember(l,0,"None");
		addMember(l,1,"SphereMap");
		addMember(l,2,"Object");
		addMember(l,3,"EyeLinear");
		addMember(l,4,"CubeReflect");
		addMember(l,5,"CubeNormal");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
