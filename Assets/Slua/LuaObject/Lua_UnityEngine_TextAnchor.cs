using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextAnchor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.TextAnchor o = (UnityEngine.TextAnchor)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.TextAnchor");
		addMember(l,0,"UpperLeft");
		addMember(l,1,"UpperCenter");
		addMember(l,2,"UpperRight");
		addMember(l,3,"MiddleLeft");
		addMember(l,4,"MiddleCenter");
		addMember(l,5,"MiddleRight");
		addMember(l,6,"LowerLeft");
		addMember(l,7,"LowerCenter");
		addMember(l,8,"LowerRight");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
