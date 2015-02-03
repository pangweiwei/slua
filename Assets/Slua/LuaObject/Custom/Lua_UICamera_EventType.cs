using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICamera_EventType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UICamera.EventType");
		addMember(l,0,"World");
		addMember(l,1,"UI");
		addMember(l,2,"Unity2D");
		LuaDLL.lua_pop(l, 1);
	}
}
