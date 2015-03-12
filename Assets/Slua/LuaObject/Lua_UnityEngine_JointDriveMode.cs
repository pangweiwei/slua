using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointDriveMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.JointDriveMode");
		addMember(l,0,"None");
		addMember(l,1,"Position");
		addMember(l,2,"Velocity");
		addMember(l,3,"PositionAndVelocity");
		LuaDLL.lua_pop(l, 1);
	}
}
