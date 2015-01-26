using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanLimit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useDefaultValues(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		pushValue(l,o.useDefaultValues);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useDefaultValues(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useDefaultValues=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_axisLength(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		pushValue(l,o.axisLength);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_axisLength(IntPtr l) {
		UnityEngine.HumanLimit o = (UnityEngine.HumanLimit)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.axisLength=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanLimit");
		addMember(l,"useDefaultValues",get_useDefaultValues,set_useDefaultValues);
		addMember(l,"min",get_min,set_min);
		addMember(l,"max",get_max,set_max);
		addMember(l,"center",get_center,set_center);
		addMember(l,"axisLength",get_axisLength,set_axisLength);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HumanLimit));
	}
}
