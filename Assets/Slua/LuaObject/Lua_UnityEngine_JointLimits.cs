using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointLimits : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		System.Single v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minBounce(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		pushValue(l,o.minBounce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minBounce(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minBounce=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		System.Single v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxBounce(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		pushValue(l,o.maxBounce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxBounce(IntPtr l) {
		UnityEngine.JointLimits o = checkSelf<UnityEngine.JointLimits>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxBounce=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointLimits");
		addMember(l,get_min, "get_min");
		addMember(l,set_min, "set_min");
		addMember(l,get_minBounce, "get_minBounce");
		addMember(l,set_minBounce, "set_minBounce");
		addMember(l,get_max, "get_max");
		addMember(l,set_max, "set_max");
		addMember(l,get_maxBounce, "get_maxBounce");
		addMember(l,set_maxBounce, "set_maxBounce");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.JointLimits));
		LuaDLL.lua_pop(l, 1);
	}
}
