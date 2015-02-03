using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIGrid_Arrangement : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIGrid.Arrangement");
		addMember(l,0,"Horizontal");
		addMember(l,1,"Vertical");
		LuaDLL.lua_pop(l, 1);
	}
}
