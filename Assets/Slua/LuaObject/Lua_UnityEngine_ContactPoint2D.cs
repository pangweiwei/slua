using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ContactPoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.ContactPoint2D o = checkSelf<UnityEngine.ContactPoint2D>(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ContactPoint2D o = checkSelf<UnityEngine.ContactPoint2D>(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.ContactPoint2D o = checkSelf<UnityEngine.ContactPoint2D>(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_otherCollider(IntPtr l) {
		UnityEngine.ContactPoint2D o = checkSelf<UnityEngine.ContactPoint2D>(l);
		pushValue(l,o.otherCollider);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ContactPoint2D");
		addMember(l,get_point, "get_point");
		addMember(l,get_normal, "get_normal");
		addMember(l,get_collider, "get_collider");
		addMember(l,get_otherCollider, "get_otherCollider");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ContactPoint2D));
		LuaDLL.lua_pop(l, 1);
	}
}
