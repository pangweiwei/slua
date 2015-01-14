using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderTextureFormat : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.RenderTextureFormat o = (UnityEngine.RenderTextureFormat)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderTextureFormat");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "ARGB32");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Depth");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "ARGBHalf");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "RGB565");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "ARGB4444");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "ARGB1555");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "Default");
		LuaDLL.lua_pushinteger(l, 9);
		LuaDLL.lua_setfield(l, -2, "DefaultHDR");
		LuaDLL.lua_pushinteger(l, 11);
		LuaDLL.lua_setfield(l, -2, "ARGBFloat");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "RGFloat");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "RGHalf");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "RFloat");
		LuaDLL.lua_pushinteger(l, 15);
		LuaDLL.lua_setfield(l, -2, "RHalf");
		LuaDLL.lua_pushinteger(l, 16);
		LuaDLL.lua_setfield(l, -2, "R8");
		LuaDLL.lua_pushinteger(l, 17);
		LuaDLL.lua_setfield(l, -2, "ARGBInt");
		LuaDLL.lua_pushinteger(l, 18);
		LuaDLL.lua_setfield(l, -2, "RGInt");
		LuaDLL.lua_pushinteger(l, 19);
		LuaDLL.lua_setfield(l, -2, "RInt");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
