using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIScrollView_ShowCondition : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIScrollView.ShowCondition");
		addMember(l,0,"Always");
		addMember(l,1,"OnlyIfNeeded");
		addMember(l,2,"WhenDragging");
		LuaDLL.lua_pop(l, 1);
	}
}
