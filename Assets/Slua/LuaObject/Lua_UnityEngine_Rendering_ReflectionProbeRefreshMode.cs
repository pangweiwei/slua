using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_ReflectionProbeRefreshMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ReflectionProbeRefreshMode");
		addMember(l,0,"OnAwake");
		addMember(l,1,"EveryFrame");
		addMember(l,2,"ViaScripting");
		LuaDLL.lua_pop(l, 1);
	}
}
