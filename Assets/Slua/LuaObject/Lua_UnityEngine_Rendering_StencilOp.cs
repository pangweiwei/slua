using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_StencilOp : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.StencilOp");
		addMember(l,0,"Keep");
		addMember(l,1,"Zero");
		addMember(l,2,"Replace");
		addMember(l,3,"IncrementSaturate");
		addMember(l,4,"DecrementSaturate");
		addMember(l,5,"Invert");
		addMember(l,6,"IncrementWrap");
		addMember(l,7,"DecrementWrap");
		LuaDLL.lua_pop(l, 1);
	}
}
