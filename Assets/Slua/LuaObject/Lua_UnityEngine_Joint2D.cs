﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Joint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Joint2D o;
		o=new UnityEngine.Joint2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedBody(IntPtr l) {
		UnityEngine.Joint2D o = (UnityEngine.Joint2D)checkSelf(l);
		pushValue(l,o.connectedBody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedBody(IntPtr l) {
		UnityEngine.Joint2D o = (UnityEngine.Joint2D)checkSelf(l);
		UnityEngine.Rigidbody2D v;
		checkType(l,2,out v);
		o.connectedBody=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collideConnected(IntPtr l) {
		UnityEngine.Joint2D o = (UnityEngine.Joint2D)checkSelf(l);
		pushValue(l,o.collideConnected);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collideConnected(IntPtr l) {
		UnityEngine.Joint2D o = (UnityEngine.Joint2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.collideConnected=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Joint2D");
		addMember(l,"connectedBody",get_connectedBody,set_connectedBody,true);
		addMember(l,"collideConnected",get_collideConnected,set_collideConnected,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Joint2D),typeof(UnityEngine.Behaviour));
	}
}
