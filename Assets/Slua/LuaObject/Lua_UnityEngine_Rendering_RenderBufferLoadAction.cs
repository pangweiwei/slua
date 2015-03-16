using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_RenderBufferLoadAction : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.RenderBufferLoadAction");
		addMember(l,0,"Load");
		addMember(l,2,"DontCare");
		LuaDLL.lua_pop(l, 1);
	}
}
