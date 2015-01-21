using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_CanvasUpdate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.UI.CanvasUpdate o = (UnityEngine.UI.CanvasUpdate)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.CanvasUpdate");
		addMember(l,0,"Prelayout");
		addMember(l,1,"Layout");
		addMember(l,2,"PostLayout");
		addMember(l,3,"PreRender");
		addMember(l,4,"LatePreRender");
		addMember(l,5,"MaxUpdateValue");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
