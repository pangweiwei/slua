using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITable_Direction : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UITable.Direction");
		addMember(l,0,"Down");
		addMember(l,1,"Up");
		LuaDLL.lua_pop(l, 1);
	}
}
