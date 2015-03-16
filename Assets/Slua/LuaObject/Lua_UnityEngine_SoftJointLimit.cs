﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SoftJointLimit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limit(IntPtr l) {
		UnityEngine.SoftJointLimit o = (UnityEngine.SoftJointLimit)checkSelf(l);
		pushValue(l,o.limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limit(IntPtr l) {
		UnityEngine.SoftJointLimit o = (UnityEngine.SoftJointLimit)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.limit=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounciness(IntPtr l) {
		UnityEngine.SoftJointLimit o = (UnityEngine.SoftJointLimit)checkSelf(l);
		pushValue(l,o.bounciness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounciness(IntPtr l) {
		UnityEngine.SoftJointLimit o = (UnityEngine.SoftJointLimit)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.bounciness=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contactDistance(IntPtr l) {
		UnityEngine.SoftJointLimit o = (UnityEngine.SoftJointLimit)checkSelf(l);
		pushValue(l,o.contactDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contactDistance(IntPtr l) {
		UnityEngine.SoftJointLimit o = (UnityEngine.SoftJointLimit)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.contactDistance=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SoftJointLimit");
		addMember(l,"limit",get_limit,set_limit,true);
		addMember(l,"bounciness",get_bounciness,set_bounciness,true);
		addMember(l,"contactDistance",get_contactDistance,set_contactDistance,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SoftJointLimit));
	}
}
