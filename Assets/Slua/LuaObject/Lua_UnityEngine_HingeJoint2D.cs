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
			UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
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
			UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
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
			UnityEngine.HingeJoint2D self=(UnityEngine.HingeJoint2D)checkSelf(l);
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
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLimits(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.useLimits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLimits(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useLimits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		UnityEngine.JointMotor2D v;
		checkType(l,2,out v);
		o.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limits(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.limits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limits(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		UnityEngine.JointAngleLimits2D v;
		checkType(l,2,out v);
		o.limits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limitState(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.limitState);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referenceAngle(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.referenceAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointAngle(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.jointAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointSpeed(IntPtr l) {
		UnityEngine.HingeJoint2D o = (UnityEngine.HingeJoint2D)checkSelf(l);
		pushValue(l,o.jointSpeed);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HingeJoint2D");
		addMember(l,GetReactionForce);
		addMember(l,GetReactionTorque);
		addMember(l,GetMotorTorque);
		addMember(l,"useMotor",get_useMotor,set_useMotor);
		addMember(l,"useLimits",get_useLimits,set_useLimits);
		addMember(l,"motor",get_motor,set_motor);
		addMember(l,"limits",get_limits,set_limits);
		addMember(l,"limitState",get_limitState,null);
		addMember(l,"referenceAngle",get_referenceAngle,null);
		addMember(l,"jointAngle",get_jointAngle,null);
		addMember(l,"jointSpeed",get_jointSpeed,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HingeJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
