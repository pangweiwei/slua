using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIBasicSprite_AdvancedType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIBasicSprite.AdvancedType");
		addMember(l,0,"Invisible");
		addMember(l,1,"Sliced");
		addMember(l,2,"Tiled");
		LuaDLL.lua_pop(l, 1);
	}
}
