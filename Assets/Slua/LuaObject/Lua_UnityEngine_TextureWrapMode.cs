using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextureWrapMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TextureWrapMode");
		addMember(l,0,"Repeat");
		addMember(l,1,"Clamp");
		LuaDLL.lua_pop(l, 1);
	}
}
