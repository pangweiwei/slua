using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GridLayoutGroup_Axis : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.GridLayoutGroup.Axis");
		addMember(l,0,"Horizontal");
		addMember(l,1,"Vertical");
		LuaDLL.lua_pop(l, 1);
	}
}
