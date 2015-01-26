using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ThreadPriority : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ThreadPriority");
		addMember(l,0,"Low");
		addMember(l,1,"BelowNormal");
		addMember(l,2,"Normal");
		addMember(l,4,"High");
		LuaDLL.lua_pop(l, 1);
	}
}
