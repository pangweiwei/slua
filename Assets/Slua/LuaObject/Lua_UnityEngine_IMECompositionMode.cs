using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_IMECompositionMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.IMECompositionMode");
		addMember(l,0,"Auto");
		addMember(l,1,"On");
		addMember(l,2,"Off");
		LuaDLL.lua_pop(l, 1);
	}
}
