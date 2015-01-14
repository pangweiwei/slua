using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OcclusionPortal : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.OcclusionPortal o;
		if(matchType(l,1)){
			o=new UnityEngine.OcclusionPortal();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_open(IntPtr l) {
		UnityEngine.OcclusionPortal o = checkSelf<UnityEngine.OcclusionPortal>(l);
		pushValue(l,o.open);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_open(IntPtr l) {
		UnityEngine.OcclusionPortal o = checkSelf<UnityEngine.OcclusionPortal>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.open=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OcclusionPortal");
		addMember(l,get_open, "get_open");
		addMember(l,set_open, "set_open");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.OcclusionPortal),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
