﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OcclusionPortal : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.OcclusionPortal o;
		o=new UnityEngine.OcclusionPortal();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_open(IntPtr l) {
		UnityEngine.OcclusionPortal o = (UnityEngine.OcclusionPortal)checkSelf(l);
		pushValue(l,o.open);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_open(IntPtr l) {
		UnityEngine.OcclusionPortal o = (UnityEngine.OcclusionPortal)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.open=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OcclusionPortal");
		addMember(l,"open",get_open,set_open,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.OcclusionPortal),typeof(UnityEngine.Component));
	}
}
