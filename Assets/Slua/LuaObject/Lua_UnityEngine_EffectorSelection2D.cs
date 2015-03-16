using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EffectorSelection2D : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.EffectorSelection2D");
		addMember(l,0,"Rigidbody");
		addMember(l,1,"Collider");
		LuaDLL.lua_pop(l, 1);
	}
}
