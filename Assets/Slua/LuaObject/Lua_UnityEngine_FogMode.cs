﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_FogMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.FogMode");
		addMember(l,1,"Linear");
		addMember(l,2,"Exponential");
		addMember(l,3,"ExponentialSquared");
		LuaDLL.lua_pop(l, 1);
	}
}
