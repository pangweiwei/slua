using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICamera_ControlScheme : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UICamera.ControlScheme");
		addMember(l,0,"Mouse");
		addMember(l,1,"Touch");
		addMember(l,2,"Controller");
		LuaDLL.lua_pop(l, 1);
	}
}
