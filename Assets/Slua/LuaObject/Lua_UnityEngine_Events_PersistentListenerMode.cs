using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Events_PersistentListenerMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.Events.PersistentListenerMode o = (UnityEngine.Events.PersistentListenerMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Events.PersistentListenerMode");
		addMember(l,0,"EventDefined");
		addMember(l,1,"Void");
		addMember(l,2,"Object");
		addMember(l,3,"Int");
		addMember(l,4,"Float");
		addMember(l,5,"String");
		addMember(l,6,"Bool");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
