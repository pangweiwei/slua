using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WindZoneMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WindZoneMode");
		addMember(l,0,"Directional");
		addMember(l,1,"Spherical");
		LuaDLL.lua_pop(l, 1);
	}
}
