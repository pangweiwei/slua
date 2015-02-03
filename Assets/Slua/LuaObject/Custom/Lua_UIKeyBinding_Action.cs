using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIKeyBinding_Action : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIKeyBinding.Action");
		addMember(l,0,"PressAndClick");
		addMember(l,1,"Select");
		addMember(l,2,"All");
		LuaDLL.lua_pop(l, 1);
	}
}
