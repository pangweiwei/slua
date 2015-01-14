using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_StencilOp : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.Rendering.StencilOp o = (UnityEngine.Rendering.StencilOp)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.StencilOp");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "Keep");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Zero");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "Replace");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "IncrementSaturate");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "DecrementSaturate");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "Invert");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "IncrementWrap");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "DecrementWrap");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
