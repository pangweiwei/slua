using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GridLayoutGroup_Corner : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.GridLayoutGroup.Corner");
		addMember(l,0,"UpperLeft");
		addMember(l,1,"UpperRight");
		addMember(l,2,"LowerLeft");
		addMember(l,3,"LowerRight");
		LuaDLL.lua_pop(l, 1);
	}
}
