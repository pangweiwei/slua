﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_ReflectionProbeType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.ReflectionProbeType");
		addMember(l,0,"Cube");
		addMember(l,1,"Card");
		LuaDLL.lua_pop(l, 1);
	}
}
