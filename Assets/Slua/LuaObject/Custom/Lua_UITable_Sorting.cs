using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITable_Sorting : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UITable.Sorting");
		addMember(l,0,"None");
		addMember(l,1,"Alphabetic");
		addMember(l,2,"Horizontal");
		addMember(l,3,"Vertical");
		addMember(l,4,"Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
