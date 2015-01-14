using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DrivenTransformProperties : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.DrivenTransformProperties o = (UnityEngine.DrivenTransformProperties)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DrivenTransformProperties");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "None");
		LuaDLL.lua_pushinteger(l, -1);
		LuaDLL.lua_setfield(l, -2, "All");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "AnchoredPositionX");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "AnchoredPositionY");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "AnchoredPositionZ");
		LuaDLL.lua_pushinteger(l, 16);
		LuaDLL.lua_setfield(l, -2, "Rotation");
		LuaDLL.lua_pushinteger(l, 32);
		LuaDLL.lua_setfield(l, -2, "ScaleX");
		LuaDLL.lua_pushinteger(l, 64);
		LuaDLL.lua_setfield(l, -2, "ScaleY");
		LuaDLL.lua_pushinteger(l, 128);
		LuaDLL.lua_setfield(l, -2, "ScaleZ");
		LuaDLL.lua_pushinteger(l, 256);
		LuaDLL.lua_setfield(l, -2, "AnchorMinX");
		LuaDLL.lua_pushinteger(l, 512);
		LuaDLL.lua_setfield(l, -2, "AnchorMinY");
		LuaDLL.lua_pushinteger(l, 1024);
		LuaDLL.lua_setfield(l, -2, "AnchorMaxX");
		LuaDLL.lua_pushinteger(l, 2048);
		LuaDLL.lua_setfield(l, -2, "AnchorMaxY");
		LuaDLL.lua_pushinteger(l, 4096);
		LuaDLL.lua_setfield(l, -2, "SizeDeltaX");
		LuaDLL.lua_pushinteger(l, 8192);
		LuaDLL.lua_setfield(l, -2, "SizeDeltaY");
		LuaDLL.lua_pushinteger(l, 16384);
		LuaDLL.lua_setfield(l, -2, "PivotX");
		LuaDLL.lua_pushinteger(l, 32768);
		LuaDLL.lua_setfield(l, -2, "PivotY");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "AnchoredPosition");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "AnchoredPosition3D");
		LuaDLL.lua_pushinteger(l, 224);
		LuaDLL.lua_setfield(l, -2, "Scale");
		LuaDLL.lua_pushinteger(l, 768);
		LuaDLL.lua_setfield(l, -2, "AnchorMin");
		LuaDLL.lua_pushinteger(l, 3072);
		LuaDLL.lua_setfield(l, -2, "AnchorMax");
		LuaDLL.lua_pushinteger(l, 3840);
		LuaDLL.lua_setfield(l, -2, "Anchors");
		LuaDLL.lua_pushinteger(l, 12288);
		LuaDLL.lua_setfield(l, -2, "SizeDelta");
		LuaDLL.lua_pushinteger(l, 49152);
		LuaDLL.lua_setfield(l, -2, "Pivot");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
