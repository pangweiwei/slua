using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PointerEventData_FramePressState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.EventSystems.PointerEventData.FramePressState o = (UnityEngine.EventSystems.PointerEventData.FramePressState)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.EventSystems.PointerEventData.FramePressState");
		addMember(l,0,"Pressed");
		addMember(l,1,"Released");
		addMember(l,2,"PressedAndReleased");
		addMember(l,3,"NotChanged");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
