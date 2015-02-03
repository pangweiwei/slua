using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonColor_State : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIButtonColor.State");
		addMember(l,0,"Normal");
		addMember(l,1,"Hover");
		addMember(l,2,"Pressed");
		addMember(l,3,"Disabled");
		LuaDLL.lua_pop(l, 1);
	}
}
