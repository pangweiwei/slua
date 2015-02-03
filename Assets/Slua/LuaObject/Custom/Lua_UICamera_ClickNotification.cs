using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICamera_ClickNotification : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UICamera.ClickNotification");
		addMember(l,0,"None");
		addMember(l,1,"Always");
		addMember(l,2,"BasedOnDelta");
		LuaDLL.lua_pop(l, 1);
	}
}
