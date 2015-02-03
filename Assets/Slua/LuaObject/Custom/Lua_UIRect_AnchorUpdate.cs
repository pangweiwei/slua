using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIRect_AnchorUpdate : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIRect.AnchorUpdate");
		addMember(l,0,"OnEnable");
		addMember(l,1,"OnUpdate");
		addMember(l,2,"OnStart");
		LuaDLL.lua_pop(l, 1);
	}
}
