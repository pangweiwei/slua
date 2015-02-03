using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITextList_Style : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UITextList.Style");
		addMember(l,0,"Text");
		addMember(l,1,"Chat");
		LuaDLL.lua_pop(l, 1);
	}
}
