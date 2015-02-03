using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIInput_OnReturnKey : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIInput.OnReturnKey");
		addMember(l,0,"Default");
		addMember(l,1,"Submit");
		addMember(l,2,"NewLine");
		LuaDLL.lua_pop(l, 1);
	}
}
