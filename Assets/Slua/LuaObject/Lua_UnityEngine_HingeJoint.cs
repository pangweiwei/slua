using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HingeJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.HingeJoint o;
		o=new UnityEngine.HingeJoint();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		UnityEngine.JointMotor v;
		checkType(l,2,out v);
		o.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limits(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.limits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limits(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		UnityEngine.JointLimits v;
		checkType(l,2,out v);
		o.limits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spring(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.spring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spring(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		UnityEngine.JointSpring v;
		checkType(l,2,out v);
		o.spring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMotor(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLimits(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.useLimits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLimits(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useLimits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useSpring(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.useSpring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useSpring(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useSpring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angle(IntPtr l) {
		UnityEngine.HingeJoint o = (UnityEngine.HingeJoint)checkSelf(l);
		pushValue(l,o.angle);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HingeJoint");
		addMember(l,"motor",get_motor,set_motor,true);
		addMember(l,"limits",get_limits,set_limits,true);
		addMember(l,"spring",get_spring,set_spring,true);
		addMember(l,"useMotor",get_useMotor,set_useMotor,true);
		addMember(l,"useLimits",get_useLimits,set_useLimits,true);
		addMember(l,"useSpring",get_useSpring,set_useSpring,true);
		addMember(l,"velocity",get_velocity,null,true);
		addMember(l,"angle",get_angle,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HingeJoint),typeof(UnityEngine.Joint));
	}
}
