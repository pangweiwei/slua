using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIKeyBinding_Modifier : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIKeyBinding.Modifier");
		addMember(l,0,"None");
		addMember(l,1,"Shift");
		addMember(l,2,"Control");
		addMember(l,3,"Alt");
		LuaDLL.lua_pop(l, 1);
	}
}
