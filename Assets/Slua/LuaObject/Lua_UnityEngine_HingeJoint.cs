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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
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
		addMember(l,"motor",get_motor,set_motor);
		addMember(l,"limits",get_limits,set_limits);
		addMember(l,"spring",get_spring,set_spring);
		addMember(l,"useMotor",get_useMotor,set_useMotor);
		addMember(l,"useLimits",get_useLimits,set_useLimits);
		addMember(l,"useSpring",get_useSpring,set_useSpring);
		addMember(l,"velocity",get_velocity,null);
		addMember(l,"angle",get_angle,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HingeJoint),typeof(UnityEngine.Joint));
	}
}
