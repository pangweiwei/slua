using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIWidget_AspectRatioSource : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIWidget.AspectRatioSource");
		addMember(l,0,"Free");
		addMember(l,1,"BasedOnWidth");
		addMember(l,2,"BasedOnHeight");
		LuaDLL.lua_pop(l, 1);
	}
}
