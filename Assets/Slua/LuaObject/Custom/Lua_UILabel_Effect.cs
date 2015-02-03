using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UILabel_Effect : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UILabel.Effect");
		addMember(l,0,"None");
		addMember(l,1,"Shadow");
		addMember(l,2,"Outline");
		LuaDLL.lua_pop(l, 1);
	}
}
