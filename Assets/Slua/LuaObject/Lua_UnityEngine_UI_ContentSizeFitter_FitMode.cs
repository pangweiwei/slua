using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ContentSizeFitter_FitMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.ContentSizeFitter.FitMode o = (UnityEngine.UI.ContentSizeFitter.FitMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.ContentSizeFitter.FitMode");
		addMember(l,0,"Unconstrained");
		addMember(l,1,"MinSize");
		addMember(l,2,"PreferredSize");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
