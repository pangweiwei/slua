using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIRoot_Constraint : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIRoot.Constraint");
		addMember(l,0,"Fit");
		addMember(l,1,"Fill");
		addMember(l,2,"FitWidth");
		addMember(l,3,"FitHeight");
		LuaDLL.lua_pop(l, 1);
	}
}
