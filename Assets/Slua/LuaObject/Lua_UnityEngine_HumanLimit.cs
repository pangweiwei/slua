using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanLimit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useDefaultValues(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		pushValue(l,o.useDefaultValues);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useDefaultValues(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useDefaultValues=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_axisLength(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		pushValue(l,o.axisLength);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_axisLength(IntPtr l) {
		UnityEngine.HumanLimit o = checkSelf<UnityEngine.HumanLimit>(l);
		System.Single v;
		checkType(l,2,out v);
		o.axisLength=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanLimit");
		addMember(l,get_useDefaultValues, "get_useDefaultValues");
		addMember(l,set_useDefaultValues, "set_useDefaultValues");
		addMember(l,get_min, "get_min");
		addMember(l,set_min, "set_min");
		addMember(l,get_max, "get_max");
		addMember(l,set_max, "set_max");
		addMember(l,get_center, "get_center");
		addMember(l,set_center, "set_center");
		addMember(l,get_axisLength, "get_axisLength");
		addMember(l,set_axisLength, "set_axisLength");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.HumanLimit));
		LuaDLL.lua_pop(l, 1);
	}
}
