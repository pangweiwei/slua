using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPopupList_OpenOn : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIPopupList.OpenOn");
		addMember(l,0,"ClickOrTap");
		addMember(l,1,"RightClick");
		addMember(l,2,"DoubleClick");
		addMember(l,3,"Manual");
		LuaDLL.lua_pop(l, 1);
	}
}
