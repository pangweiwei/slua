using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Selectable_Transition : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.Selectable.Transition");
		addMember(l,0,"None");
		addMember(l,1,"ColorTint");
		addMember(l,2,"SpriteSwap");
		addMember(l,3,"Animation");
		LuaDLL.lua_pop(l, 1);
	}
}
