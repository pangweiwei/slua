using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIInput_InputType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIInput.InputType");
		addMember(l,0,"Standard");
		addMember(l,1,"AutoCorrect");
		addMember(l,2,"Password");
		LuaDLL.lua_pop(l, 1);
	}
}
