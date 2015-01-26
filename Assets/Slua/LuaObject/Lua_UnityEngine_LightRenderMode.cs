using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightRenderMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightRenderMode");
		addMember(l,0,"Auto");
		addMember(l,1,"ForcePixel");
		addMember(l,2,"ForceVertex");
		LuaDLL.lua_pop(l, 1);
	}
}
