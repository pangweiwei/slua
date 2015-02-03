using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIStretch_Style : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIStretch.Style");
		addMember(l,0,"None");
		addMember(l,1,"Horizontal");
		addMember(l,2,"Vertical");
		addMember(l,3,"Both");
		addMember(l,4,"BasedOnHeight");
		addMember(l,5,"FillKeepingRatio");
		addMember(l,6,"FitInternalKeepingRatio");
		LuaDLL.lua_pop(l, 1);
	}
}
