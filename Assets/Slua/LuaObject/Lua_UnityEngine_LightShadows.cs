using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightShadows : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightShadows");
		addMember(l,0,"None");
		addMember(l,1,"Hard");
		addMember(l,2,"Soft");
		LuaDLL.lua_pop(l, 1);
	}
}
