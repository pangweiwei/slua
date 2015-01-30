using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointSuspension2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dampingRatio(IntPtr l) {
		UnityEngine.JointSuspension2D o = (UnityEngine.JointSuspension2D)checkSelf(l);
		pushValue(l,o.dampingRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dampingRatio(IntPtr l) {
		UnityEngine.JointSuspension2D o = (UnityEngine.JointSuspension2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.dampingRatio=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frequency(IntPtr l) {
		UnityEngine.JointSuspension2D o = (UnityEngine.JointSuspension2D)checkSelf(l);
		pushValue(l,o.frequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frequency(IntPtr l) {
		UnityEngine.JointSuspension2D o = (UnityEngine.JointSuspension2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.frequency=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angle(IntPtr l) {
		UnityEngine.JointSuspension2D o = (UnityEngine.JointSuspension2D)checkSelf(l);
		pushValue(l,o.angle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angle(IntPtr l) {
		UnityEngine.JointSuspension2D o = (UnityEngine.JointSuspension2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angle=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointSuspension2D");
		addMember(l,"dampingRatio",get_dampingRatio,set_dampingRatio,true);
		addMember(l,"frequency",get_frequency,set_frequency,true);
		addMember(l,"angle",get_angle,set_angle,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointSuspension2D));
	}
}
