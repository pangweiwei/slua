using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WebCamDevice : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.WebCamDevice o = checkSelf<UnityEngine.WebCamDevice>(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isFrontFacing(IntPtr l) {
		UnityEngine.WebCamDevice o = checkSelf<UnityEngine.WebCamDevice>(l);
		pushValue(l,o.isFrontFacing);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WebCamDevice");
		addMember(l,get_name, "get_name");
		addMember(l,get_isFrontFacing, "get_isFrontFacing");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.WebCamDevice));
		LuaDLL.lua_pop(l, 1);
	}
}
