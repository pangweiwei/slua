using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TransparencySortMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TransparencySortMode");
		addMember(l,0,"Default");
		addMember(l,1,"Perspective");
		addMember(l,2,"Orthographic");
		LuaDLL.lua_pop(l, 1);
	}
}
