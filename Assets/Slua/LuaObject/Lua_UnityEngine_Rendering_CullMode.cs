using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_CullMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.CullMode");
		addMember(l,0,"Off");
		addMember(l,1,"Front");
		addMember(l,2,"Back");
		LuaDLL.lua_pop(l, 1);
	}
}
