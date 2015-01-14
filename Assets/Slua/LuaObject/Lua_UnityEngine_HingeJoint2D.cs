using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HingeJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.HingeJoint2D o;
		if(matchType(l,1)){
			o=new UnityEngine.HingeJoint2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionForce(IntPtr l) {
		try{
			UnityEngine.HingeJoint2D self=checkSelf<UnityEngine.HingeJoint2D>(l);
			System.Single a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.GetReactionForce(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetReactionTorque(IntPtr l) {
		try{
			UnityEngine.HingeJoint2D self=checkSelf<UnityEngine.HingeJoint2D>(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetReactionTorque(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMotorTorque(IntPtr l) {
		try{
			UnityEngine.HingeJoint2D self=checkSelf<UnityEngine.HingeJoint2D>(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetMotorTorque(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMotor(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLimits(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.useLimits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLimits(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useLimits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		UnityEngine.JointMotor2D v;
		checkType(l,2,out v);
		o.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limits(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.limits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limits(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		UnityEngine.JointAngleLimits2D v;
		checkType(l,2,out v);
		o.limits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limitState(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.limitState);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referenceAngle(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.referenceAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointAngle(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.jointAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointSpeed(IntPtr l) {
		UnityEngine.HingeJoint2D o = checkSelf<UnityEngine.HingeJoint2D>(l);
		pushValue(l,o.jointSpeed);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HingeJoint2D");
		addMember(l,GetReactionForce, "GetReactionForce");
		addMember(l,GetReactionTorque, "GetReactionTorque");
		addMember(l,GetMotorTorque, "GetMotorTorque");
		addMember(l,get_useMotor, "get_useMotor");
		addMember(l,set_useMotor, "set_useMotor");
		addMember(l,get_useLimits, "get_useLimits");
		addMember(l,set_useLimits, "set_useLimits");
		addMember(l,get_motor, "get_motor");
		addMember(l,set_motor, "set_motor");
		addMember(l,get_limits, "get_limits");
		addMember(l,set_limits, "set_limits");
		addMember(l,get_limitState, "get_limitState");
		addMember(l,get_referenceAngle, "get_referenceAngle");
		addMember(l,get_jointAngle, "get_jointAngle");
		addMember(l,get_jointSpeed, "get_jointSpeed");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.HingeJoint2D),typeof(UnityEngine.AnchoredJoint2D));
		LuaDLL.lua_pop(l, 1);
	}
}
