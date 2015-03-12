using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightType");
		addMember(l,0,"Spot");
		addMember(l,1,"Directional");
		addMember(l,2,"Point");
		addMember(l,3,"Area");
		LuaDLL.lua_pop(l, 1);
	}
}
