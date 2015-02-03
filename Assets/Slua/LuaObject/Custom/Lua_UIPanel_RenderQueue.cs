using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPanel_RenderQueue : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIPanel.RenderQueue");
		addMember(l,0,"Automatic");
		addMember(l,1,"StartAt");
		addMember(l,2,"Explicit");
		LuaDLL.lua_pop(l, 1);
	}
}
