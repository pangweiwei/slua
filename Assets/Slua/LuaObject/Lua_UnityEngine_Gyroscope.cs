using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Gyroscope : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationRate(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		pushValue(l,o.rotationRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationRateUnbiased(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		pushValue(l,o.rotationRateUnbiased);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravity(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		pushValue(l,o.gravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_userAcceleration(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		pushValue(l,o.userAcceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attitude(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		pushValue(l,o.attitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateInterval(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		pushValue(l,o.updateInterval);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateInterval(IntPtr l) {
		UnityEngine.Gyroscope o = checkSelf<UnityEngine.Gyroscope>(l);
		System.Single v;
		checkType(l,2,out v);
		o.updateInterval=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Gyroscope");
		addMember(l,get_rotationRate, "get_rotationRate");
		addMember(l,get_rotationRateUnbiased, "get_rotationRateUnbiased");
		addMember(l,get_gravity, "get_gravity");
		addMember(l,get_userAcceleration, "get_userAcceleration");
		addMember(l,get_attitude, "get_attitude");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		addMember(l,get_updateInterval, "get_updateInterval");
		addMember(l,set_updateInterval, "set_updateInterval");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Gyroscope));
		LuaDLL.lua_pop(l, 1);
	}
}
