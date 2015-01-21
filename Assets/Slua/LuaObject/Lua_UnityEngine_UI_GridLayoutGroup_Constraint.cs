using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GridLayoutGroup_Constraint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.GridLayoutGroup.Constraint o = (UnityEngine.UI.GridLayoutGroup.Constraint)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.GridLayoutGroup.Constraint");
		addMember(l,0,"Flexible");
		addMember(l,1,"FixedColumnCount");
		addMember(l,2,"FixedRowCount");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
