using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioType : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.AudioType o = (UnityEngine.AudioType)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioType");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "UNKNOWN");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "ACC");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "AIFF");
		LuaDLL.lua_pushinteger(l, 10);
		LuaDLL.lua_setfield(l, -2, "IT");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "MOD");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "MPEG");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "OGGVORBIS");
		LuaDLL.lua_pushinteger(l, 17);
		LuaDLL.lua_setfield(l, -2, "S3M");
		LuaDLL.lua_pushinteger(l, 20);
		LuaDLL.lua_setfield(l, -2, "WAV");
		LuaDLL.lua_pushinteger(l, 21);
		LuaDLL.lua_setfield(l, -2, "XM");
		LuaDLL.lua_pushinteger(l, 22);
		LuaDLL.lua_setfield(l, -2, "XMA");
		LuaDLL.lua_pushinteger(l, 23);
		LuaDLL.lua_setfield(l, -2, "VAG");
		LuaDLL.lua_pushinteger(l, 24);
		LuaDLL.lua_setfield(l, -2, "AUDIOQUEUE");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
