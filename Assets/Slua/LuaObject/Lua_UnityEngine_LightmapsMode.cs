using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightmapsMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightmapsMode");
		addMember(l,0,"NonDirectional");
		addMember(l,1,"CombinedDirectional");
		addMember(l,2,"SeparateDirectional");
		addMember(l,0,"Single");
		addMember(l,1,"Dual");
		addMember(l,2,"Directional");
		LuaDLL.lua_pop(l, 1);
	}
}
