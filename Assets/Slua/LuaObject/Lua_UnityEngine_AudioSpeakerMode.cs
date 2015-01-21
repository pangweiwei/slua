using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioSpeakerMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.AudioSpeakerMode o = (UnityEngine.AudioSpeakerMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AudioSpeakerMode");
		addMember(l,0,"Raw");
		addMember(l,1,"Mono");
		addMember(l,2,"Stereo");
		addMember(l,3,"Quad");
		addMember(l,4,"Surround");
		addMember(l,5,"Mode5point1");
		addMember(l,6,"Mode7point1");
		addMember(l,7,"Prologic");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
