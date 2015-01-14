using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HingeJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.HingeJoint o;
		if(matchType(l,1)){
			o=new UnityEngine.HingeJoint();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		UnityEngine.JointMotor v;
		checkType(l,2,out v);
		o.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limits(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.limits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limits(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		UnityEngine.JointLimits v;
		checkType(l,2,out v);
		o.limits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spring(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.spring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spring(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		UnityEngine.JointSpring v;
		checkType(l,2,out v);
		o.spring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMotor(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLimits(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.useLimits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLimits(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useLimits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useSpring(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.useSpring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useSpring(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useSpring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angle(IntPtr l) {
		UnityEngine.HingeJoint o = checkSelf<UnityEngine.HingeJoint>(l);
		pushValue(l,o.angle);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HingeJoint");
		addMember(l,get_motor, "get_motor");
		addMember(l,set_motor, "set_motor");
		addMember(l,get_limits, "get_limits");
		addMember(l,set_limits, "set_limits");
		addMember(l,get_spring, "get_spring");
		addMember(l,set_spring, "set_spring");
		addMember(l,get_useMotor, "get_useMotor");
		addMember(l,set_useMotor, "set_useMotor");
		addMember(l,get_useLimits, "get_useLimits");
		addMember(l,set_useLimits, "set_useLimits");
		addMember(l,get_useSpring, "get_useSpring");
		addMember(l,set_useSpring, "set_useSpring");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,get_angle, "get_angle");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.HingeJoint),typeof(UnityEngine.Joint));
		LuaDLL.lua_pop(l, 1);
	}
}
