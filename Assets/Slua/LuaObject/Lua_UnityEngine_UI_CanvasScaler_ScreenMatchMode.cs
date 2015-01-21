using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_CanvasScaler_ScreenMatchMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.CanvasScaler.ScreenMatchMode o = (UnityEngine.UI.CanvasScaler.ScreenMatchMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.CanvasScaler.ScreenMatchMode");
		addMember(l,0,"MatchWidthOrHeight");
		addMember(l,1,"Expand");
		addMember(l,2,"Shrink");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
