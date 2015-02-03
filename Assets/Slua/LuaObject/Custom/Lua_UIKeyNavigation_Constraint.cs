using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIKeyNavigation_Constraint : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIKeyNavigation.Constraint");
		addMember(l,0,"None");
		addMember(l,1,"Vertical");
		addMember(l,2,"Horizontal");
		addMember(l,3,"Explicit");
		LuaDLL.lua_pop(l, 1);
	}
}
