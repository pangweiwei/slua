using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ForceMode2D : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ForceMode2D");
		addMember(l,0,"Force");
		addMember(l,1,"Impulse");
		LuaDLL.lua_pop(l, 1);
	}
}
