using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WebCamFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WebCamFlags");
		addMember(l,1,"FrontFacing");
		LuaDLL.lua_pop(l, 1);
	}
}
