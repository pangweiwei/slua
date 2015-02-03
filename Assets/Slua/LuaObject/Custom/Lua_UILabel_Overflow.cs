using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UILabel_Overflow : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UILabel.Overflow");
		addMember(l,0,"ShrinkContent");
		addMember(l,1,"ClampContent");
		addMember(l,2,"ResizeFreely");
		addMember(l,3,"ResizeHeight");
		LuaDLL.lua_pop(l, 1);
	}
}
