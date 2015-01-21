using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AvatarTarget : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.AvatarTarget o = (UnityEngine.AvatarTarget)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AvatarTarget");
		addMember(l,0,"Root");
		addMember(l,1,"Body");
		addMember(l,2,"LeftFoot");
		addMember(l,3,"RightFoot");
		addMember(l,4,"LeftHand");
		addMember(l,5,"RightHand");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
