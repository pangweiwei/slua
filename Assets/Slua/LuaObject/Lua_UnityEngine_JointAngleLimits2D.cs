using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointAngleLimits2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.JointAngleLimits2D o = checkSelf<UnityEngine.JointAngleLimits2D>(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.JointAngleLimits2D o = checkSelf<UnityEngine.JointAngleLimits2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.JointAngleLimits2D o = checkSelf<UnityEngine.JointAngleLimits2D>(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.JointAngleLimits2D o = checkSelf<UnityEngine.JointAngleLimits2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointAngleLimits2D");
		addMember(l,get_min, "get_min");
		addMember(l,set_min, "set_min");
		addMember(l,get_max, "get_max");
		addMember(l,set_max, "set_max");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.JointAngleLimits2D));
		LuaDLL.lua_pop(l, 1);
	}
}
