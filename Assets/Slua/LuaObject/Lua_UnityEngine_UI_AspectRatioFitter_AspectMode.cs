using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_AspectRatioFitter_AspectMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.AspectRatioFitter.AspectMode o = (UnityEngine.UI.AspectRatioFitter.AspectMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.AspectRatioFitter.AspectMode");
		addMember(l,0,"None");
		addMember(l,1,"WidthControlsHeight");
		addMember(l,2,"HeightControlsWidth");
		addMember(l,3,"FitInParent");
		addMember(l,4,"EnvelopeParent");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
