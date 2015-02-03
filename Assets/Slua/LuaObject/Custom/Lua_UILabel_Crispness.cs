using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UILabel_Crispness : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UILabel.Crispness");
		addMember(l,0,"Never");
		addMember(l,1,"OnDesktop");
		addMember(l,2,"Always");
		LuaDLL.lua_pop(l, 1);
	}
}
