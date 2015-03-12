﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ContactPoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.ContactPoint2D o = (UnityEngine.ContactPoint2D)checkSelf(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ContactPoint2D o = (UnityEngine.ContactPoint2D)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.ContactPoint2D o = (UnityEngine.ContactPoint2D)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_otherCollider(IntPtr l) {
		UnityEngine.ContactPoint2D o = (UnityEngine.ContactPoint2D)checkSelf(l);
		pushValue(l,o.otherCollider);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ContactPoint2D");
		addMember(l,"point",get_point,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"collider",get_collider,null,true);
		addMember(l,"otherCollider",get_otherCollider,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ContactPoint2D));
	}
}
