using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ForceMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ForceMode");
		addMember(l,0,"Force");
		addMember(l,5,"Acceleration");
		addMember(l,1,"Impulse");
		addMember(l,2,"VelocityChange");
		LuaDLL.lua_pop(l, 1);
	}
}
