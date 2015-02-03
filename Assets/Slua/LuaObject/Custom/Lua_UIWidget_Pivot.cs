using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIWidget_Pivot : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIWidget.Pivot");
		addMember(l,0,"TopLeft");
		addMember(l,1,"Top");
		addMember(l,2,"TopRight");
		addMember(l,3,"Left");
		addMember(l,4,"Center");
		addMember(l,5,"Right");
		addMember(l,6,"BottomLeft");
		addMember(l,7,"Bottom");
		addMember(l,8,"BottomRight");
		LuaDLL.lua_pop(l, 1);
	}
}
