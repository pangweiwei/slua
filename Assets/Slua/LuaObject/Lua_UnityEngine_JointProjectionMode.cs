﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointProjectionMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.JointProjectionMode");
		addMember(l,0,"None");
		addMember(l,1,"PositionAndRotation");
		addMember(l,2,"PositionOnly");
		LuaDLL.lua_pop(l, 1);
	}
}
