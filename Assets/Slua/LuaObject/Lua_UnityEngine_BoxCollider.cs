﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BoxCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.BoxCollider o;
		o=new UnityEngine.BoxCollider();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.BoxCollider o = (UnityEngine.BoxCollider)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.BoxCollider o = (UnityEngine.BoxCollider)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.BoxCollider o = (UnityEngine.BoxCollider)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.BoxCollider o = (UnityEngine.BoxCollider)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BoxCollider");
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"size",get_size,set_size,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.BoxCollider),typeof(UnityEngine.Collider));
	}
}
