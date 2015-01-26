using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorCullingMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AnimatorCullingMode");
		addMember(l,0,"AlwaysAnimate");
		addMember(l,1,"BasedOnRenderers");
		LuaDLL.lua_pop(l, 1);
	}
}
