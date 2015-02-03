using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIBasicSprite_FillDirection : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIBasicSprite.FillDirection");
		addMember(l,0,"Horizontal");
		addMember(l,1,"Vertical");
		addMember(l,2,"Radial90");
		addMember(l,3,"Radial180");
		addMember(l,4,"Radial360");
		LuaDLL.lua_pop(l, 1);
	}
}
