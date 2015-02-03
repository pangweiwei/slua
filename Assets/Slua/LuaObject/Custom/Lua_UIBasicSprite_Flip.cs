using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIBasicSprite_Flip : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIBasicSprite.Flip");
		addMember(l,0,"Nothing");
		addMember(l,1,"Horizontally");
		addMember(l,2,"Vertically");
		addMember(l,3,"Both");
		LuaDLL.lua_pop(l, 1);
	}
}
