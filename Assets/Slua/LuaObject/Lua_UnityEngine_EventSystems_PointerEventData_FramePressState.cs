using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PointerEventData_FramePressState : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.EventSystems.PointerEventData.FramePressState");
		addMember(l,0,"Pressed");
		addMember(l,1,"Released");
		addMember(l,2,"PressedAndReleased");
		addMember(l,3,"NotChanged");
		LuaDLL.lua_pop(l, 1);
	}
}
