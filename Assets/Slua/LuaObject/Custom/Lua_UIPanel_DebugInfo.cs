using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPanel_DebugInfo : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIPanel.DebugInfo");
		addMember(l,0,"None");
		addMember(l,1,"Gizmos");
		addMember(l,2,"Geometry");
		LuaDLL.lua_pop(l, 1);
	}
}
