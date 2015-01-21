using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_GraphicRaycaster_BlockingObjects : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.GraphicRaycaster.BlockingObjects o = (UnityEngine.UI.GraphicRaycaster.BlockingObjects)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.GraphicRaycaster.BlockingObjects");
		addMember(l,0,"None");
		addMember(l,1,"TwoD");
		addMember(l,2,"ThreeD");
		addMember(l,3,"All");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
