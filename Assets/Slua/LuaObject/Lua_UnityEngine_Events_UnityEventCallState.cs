using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Events_UnityEventCallState : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Events.UnityEventCallState");
		addMember(l,0,"Off");
		addMember(l,1,"EditorAndRuntime");
		addMember(l,2,"RuntimeOnly");
		LuaDLL.lua_pop(l, 1);
	}
}
