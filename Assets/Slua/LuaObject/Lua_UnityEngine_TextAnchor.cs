using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextAnchor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.TextAnchor o = (UnityEngine.TextAnchor)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextAnchor");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "UpperLeft");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "UpperCenter");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "UpperRight");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "MiddleLeft");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "MiddleCenter");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "MiddleRight");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "LowerLeft");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "LowerCenter");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "LowerRight");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
