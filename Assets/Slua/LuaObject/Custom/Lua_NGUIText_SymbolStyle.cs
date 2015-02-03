using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUIText_SymbolStyle : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"NGUIText.SymbolStyle");
		addMember(l,0,"None");
		addMember(l,1,"Uncolored");
		addMember(l,2,"Colored");
		LuaDLL.lua_pop(l, 1);
	}
}
