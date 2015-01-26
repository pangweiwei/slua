using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderTextureReadWrite : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.RenderTextureReadWrite");
		addMember(l,0,"Default");
		addMember(l,1,"Linear");
		addMember(l,2,"sRGB");
		LuaDLL.lua_pop(l, 1);
	}
}
