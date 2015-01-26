using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ShadowProjection : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ShadowProjection");
		addMember(l,0,"CloseFit");
		addMember(l,1,"StableFit");
		LuaDLL.lua_pop(l, 1);
	}
}
