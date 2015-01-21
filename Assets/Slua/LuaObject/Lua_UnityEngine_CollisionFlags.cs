using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CollisionFlags : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.CollisionFlags o = (UnityEngine.CollisionFlags)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.CollisionFlags");
		addMember(l,0,"None");
		addMember(l,1,"Sides");
		addMember(l,2,"Above");
		addMember(l,4,"Below");
		addMember(l,1,"CollidedSides");
		addMember(l,2,"CollidedAbove");
		addMember(l,4,"CollidedBelow");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
