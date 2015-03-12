using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_QueueMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.QueueMode");
		addMember(l,0,"CompleteOthers");
		addMember(l,2,"PlayNow");
		LuaDLL.lua_pop(l, 1);
	}
}
