using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUIText_Alignment : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"NGUIText.Alignment");
		addMember(l,0,"Automatic");
		addMember(l,1,"Left");
		addMember(l,2,"Center");
		addMember(l,3,"Right");
		addMember(l,4,"Justified");
		LuaDLL.lua_pop(l, 1);
	}
}
