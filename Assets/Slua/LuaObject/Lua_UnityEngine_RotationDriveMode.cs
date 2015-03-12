using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RotationDriveMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.RotationDriveMode");
		addMember(l,0,"XYAndZ");
		addMember(l,1,"Slerp");
		LuaDLL.lua_pop(l, 1);
	}
}
