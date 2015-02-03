using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICamera_EventType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UICamera.EventType");
		addMember(l,0,"World_3D");
		addMember(l,1,"UI_3D");
		addMember(l,2,"World_2D");
		addMember(l,3,"UI_2D");
		LuaDLL.lua_pop(l, 1);
	}
}
