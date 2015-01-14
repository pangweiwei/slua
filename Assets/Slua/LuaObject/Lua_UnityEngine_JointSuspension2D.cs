using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointSuspension2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dampingRatio(IntPtr l) {
		UnityEngine.JointSuspension2D o = checkSelf<UnityEngine.JointSuspension2D>(l);
		pushValue(l,o.dampingRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dampingRatio(IntPtr l) {
		UnityEngine.JointSuspension2D o = checkSelf<UnityEngine.JointSuspension2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.dampingRatio=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frequency(IntPtr l) {
		UnityEngine.JointSuspension2D o = checkSelf<UnityEngine.JointSuspension2D>(l);
		pushValue(l,o.frequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frequency(IntPtr l) {
		UnityEngine.JointSuspension2D o = checkSelf<UnityEngine.JointSuspension2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.frequency=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angle(IntPtr l) {
		UnityEngine.JointSuspension2D o = checkSelf<UnityEngine.JointSuspension2D>(l);
		pushValue(l,o.angle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angle(IntPtr l) {
		UnityEngine.JointSuspension2D o = checkSelf<UnityEngine.JointSuspension2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.angle=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointSuspension2D");
		addMember(l,get_dampingRatio, "get_dampingRatio");
		addMember(l,set_dampingRatio, "set_dampingRatio");
		addMember(l,get_frequency, "get_frequency");
		addMember(l,set_frequency, "set_frequency");
		addMember(l,get_angle, "get_angle");
		addMember(l,set_angle, "set_angle");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.JointSuspension2D));
		LuaDLL.lua_pop(l, 1);
	}
}
