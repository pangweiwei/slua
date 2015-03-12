using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PhysicMaterialCombine : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.PhysicMaterialCombine");
		addMember(l,0,"Average");
		addMember(l,2,"Minimum");
		addMember(l,1,"Multiply");
		addMember(l,3,"Maximum");
		LuaDLL.lua_pop(l, 1);
	}
}
