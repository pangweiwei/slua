using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GraphicRaycaster_BlockingObjects : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.GraphicRaycaster.BlockingObjects");
		addMember(l,0,"None");
		addMember(l,1,"TwoD");
		addMember(l,2,"ThreeD");
		addMember(l,3,"All");
		LuaDLL.lua_pop(l, 1);
	}
}
