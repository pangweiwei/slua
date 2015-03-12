using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemSimulationSpace : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemSimulationSpace");
		addMember(l,0,"Local");
		addMember(l,1,"World");
		LuaDLL.lua_pop(l, 1);
	}
}
