using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIScrollView_DragEffect : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIScrollView.DragEffect");
		addMember(l,0,"None");
		addMember(l,1,"Momentum");
		addMember(l,2,"MomentumAndSpring");
		LuaDLL.lua_pop(l, 1);
	}
}
