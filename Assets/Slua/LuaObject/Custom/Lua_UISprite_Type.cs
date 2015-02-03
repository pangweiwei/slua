using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISprite_Type : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UISprite.Type");
		addMember(l,0,"Simple");
		addMember(l,1,"Sliced");
		addMember(l,2,"Tiled");
		addMember(l,3,"Filled");
		addMember(l,4,"Advanced");
		LuaDLL.lua_pop(l, 1);
	}
}
