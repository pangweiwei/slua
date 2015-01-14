using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RuntimePlatform : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.RuntimePlatform o = (UnityEngine.RuntimePlatform)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RuntimePlatform");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "OSXEditor");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "OSXPlayer");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "WindowsPlayer");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "OSXWebPlayer");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "OSXDashboardPlayer");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "WindowsWebPlayer");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "WindowsEditor");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "IPhonePlayer");
		LuaDLL.lua_pushinteger(l, 10);
		LuaDLL.lua_setfield(l, -2, "XBOX360");
		LuaDLL.lua_pushinteger(l, 9);
		LuaDLL.lua_setfield(l, -2, "PS3");
		LuaDLL.lua_pushinteger(l, 11);
		LuaDLL.lua_setfield(l, -2, "Android");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "NaCl");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "LinuxPlayer");
		LuaDLL.lua_pushinteger(l, 15);
		LuaDLL.lua_setfield(l, -2, "FlashPlayer");
		LuaDLL.lua_pushinteger(l, 18);
		LuaDLL.lua_setfield(l, -2, "MetroPlayerX86");
		LuaDLL.lua_pushinteger(l, 19);
		LuaDLL.lua_setfield(l, -2, "MetroPlayerX64");
		LuaDLL.lua_pushinteger(l, 20);
		LuaDLL.lua_setfield(l, -2, "MetroPlayerARM");
		LuaDLL.lua_pushinteger(l, 21);
		LuaDLL.lua_setfield(l, -2, "WP8Player");
		LuaDLL.lua_pushinteger(l, 22);
		LuaDLL.lua_setfield(l, -2, "BB10Player");
		LuaDLL.lua_pushinteger(l, 22);
		LuaDLL.lua_setfield(l, -2, "BlackBerryPlayer");
		LuaDLL.lua_pushinteger(l, 23);
		LuaDLL.lua_setfield(l, -2, "TizenPlayer");
		LuaDLL.lua_pushinteger(l, 24);
		LuaDLL.lua_setfield(l, -2, "PSP2");
		LuaDLL.lua_pushinteger(l, 25);
		LuaDLL.lua_setfield(l, -2, "PS4");
		LuaDLL.lua_pushinteger(l, 26);
		LuaDLL.lua_setfield(l, -2, "PSMPlayer");
		LuaDLL.lua_pushinteger(l, 27);
		LuaDLL.lua_setfield(l, -2, "XboxOne");
		LuaDLL.lua_pushinteger(l, 28);
		LuaDLL.lua_setfield(l, -2, "SamsungTVPlayer");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
