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
		getTypeTable(l,"UnityEngine.TexGenMode");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "None");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "SphereMap");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "Object");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "EyeLinear");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "CubeReflect");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "CubeNormal");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
