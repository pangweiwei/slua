﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Gyroscope : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationRate(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		pushValue(l,o.rotationRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationRateUnbiased(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		pushValue(l,o.rotationRateUnbiased);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravity(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		pushValue(l,o.gravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_userAcceleration(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		pushValue(l,o.userAcceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attitude(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		pushValue(l,o.attitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateInterval(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		pushValue(l,o.updateInterval);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateInterval(IntPtr l) {
		UnityEngine.Gyroscope o = (UnityEngine.Gyroscope)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.updateInterval=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Gyroscope");
		addMember(l,"rotationRate",get_rotationRate,null,true);
		addMember(l,"rotationRateUnbiased",get_rotationRateUnbiased,null,true);
		addMember(l,"gravity",get_gravity,null,true);
		addMember(l,"userAcceleration",get_userAcceleration,null,true);
		addMember(l,"attitude",get_attitude,null,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"updateInterval",get_updateInterval,set_updateInterval,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Gyroscope));
	}
}
