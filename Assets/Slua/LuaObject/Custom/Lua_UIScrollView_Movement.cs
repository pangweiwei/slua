using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIScrollView_Movement : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIScrollView.Movement");
		addMember(l,0,"Horizontal");
		addMember(l,1,"Vertical");
		addMember(l,2,"Unrestricted");
		addMember(l,3,"Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
