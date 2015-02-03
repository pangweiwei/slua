using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPopupList_Position : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIPopupList.Position");
		addMember(l,0,"Auto");
		addMember(l,1,"Above");
		addMember(l,2,"Below");
		LuaDLL.lua_pop(l, 1);
	}
}
