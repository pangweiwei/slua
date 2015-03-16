using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshObstacleShape : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.NavMeshObstacleShape");
		addMember(l,0,"Capsule");
		addMember(l,1,"Box");
		LuaDLL.lua_pop(l, 1);
	}
}
