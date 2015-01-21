using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AvatarIKGoal : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.AvatarIKGoal o = (UnityEngine.AvatarIKGoal)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AvatarIKGoal");
		addMember(l,0,"LeftFoot");
		addMember(l,1,"RightFoot");
		addMember(l,2,"LeftHand");
		addMember(l,3,"RightHand");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
