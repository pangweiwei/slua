using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CollisionDetectionMode2D : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CollisionDetectionMode2D");
		addMember(l,0,"None");
		addMember(l,1,"Continuous");
		LuaDLL.lua_pop(l, 1);
	}
}
