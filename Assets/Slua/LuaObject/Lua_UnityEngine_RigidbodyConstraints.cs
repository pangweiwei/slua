using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RigidbodyConstraints : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.RigidbodyConstraints o = (UnityEngine.RigidbodyConstraints)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RigidbodyConstraints");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "None");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "FreezePositionX");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "FreezePositionY");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "FreezePositionZ");
		LuaDLL.lua_pushinteger(l, 16);
		LuaDLL.lua_setfield(l, -2, "FreezeRotationX");
		LuaDLL.lua_pushinteger(l, 32);
		LuaDLL.lua_setfield(l, -2, "FreezeRotationY");
		LuaDLL.lua_pushinteger(l, 64);
		LuaDLL.lua_setfield(l, -2, "FreezeRotationZ");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "FreezePosition");
		LuaDLL.lua_pushinteger(l, 112);
		LuaDLL.lua_setfield(l, -2, "FreezeRotation");
		LuaDLL.lua_pushinteger(l, 126);
		LuaDLL.lua_setfield(l, -2, "FreezeAll");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
