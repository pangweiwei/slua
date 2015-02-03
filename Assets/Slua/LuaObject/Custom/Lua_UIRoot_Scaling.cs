using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIRoot_Scaling : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIRoot.Scaling");
		addMember(l,0,"Flexible");
		addMember(l,1,"Constrained");
		addMember(l,2,"ConstrainedOnMobiles");
		LuaDLL.lua_pop(l, 1);
	}
}
