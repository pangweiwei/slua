using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NPOTSupport : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.NPOTSupport");
		addMember(l,0,"None");
		addMember(l,1,"Restricted");
		addMember(l,2,"Full");
		LuaDLL.lua_pop(l, 1);
	}
}
