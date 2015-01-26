using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HideFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.HideFlags");
		addMember(l,0,"None");
		addMember(l,1,"HideInHierarchy");
		addMember(l,2,"HideInInspector");
		addMember(l,4,"DontSave");
		addMember(l,8,"NotEditable");
		addMember(l,13,"HideAndDontSave");
		LuaDLL.lua_pop(l, 1);
	}
}
