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
		getEnumTable(l,"UnityEngine.AudioType");
		addMember(l,0,"UNKNOWN");
		addMember(l,1,"ACC");
		addMember(l,2,"AIFF");
		addMember(l,10,"IT");
		addMember(l,12,"MOD");
		addMember(l,13,"MPEG");
		addMember(l,14,"OGGVORBIS");
		addMember(l,17,"S3M");
		addMember(l,20,"WAV");
		addMember(l,21,"XM");
		addMember(l,22,"XMA");
		addMember(l,23,"VAG");
		addMember(l,24,"AUDIOQUEUE");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
