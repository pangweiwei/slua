using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Scrollbar_Direction : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.Scrollbar.Direction o = (UnityEngine.UI.Scrollbar.Direction)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.Scrollbar.Direction");
		addMember(l,0,"LeftToRight");
		addMember(l,1,"RightToLeft");
		addMember(l,2,"BottomToTop");
		addMember(l,3,"TopToBottom");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
