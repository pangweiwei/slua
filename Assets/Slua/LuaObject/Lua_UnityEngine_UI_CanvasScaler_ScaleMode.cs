using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_CanvasScaler_ScaleMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.CanvasScaler.ScaleMode o = (UnityEngine.UI.CanvasScaler.ScaleMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.CanvasScaler.ScaleMode");
		addMember(l,0,"ConstantPixelSize");
		addMember(l,1,"ScaleWithScreenSize");
		addMember(l,2,"ConstantPhysicalSize");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
