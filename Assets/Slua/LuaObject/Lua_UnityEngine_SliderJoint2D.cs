using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SliderJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SliderJoint2D o;
		if(matchType(l,1)){
			o=new UnityEngine.SliderJoint2D();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMotorForce(IntPtr l) {
		try{
			UnityEngine.SliderJoint2D self=(UnityEngine.SliderJoint2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single ret=self.GetMotorForce(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angle(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.angle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angle(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.angle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMotor(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useLimits(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.useLimits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useLimits(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useLimits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		UnityEngine.JointMotor2D v;
		checkType(l,2,out v);
		o.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limits(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.limits);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limits(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		UnityEngine.JointTranslationLimits2D v;
		checkType(l,2,out v);
		o.limits=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limitState(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.limitState);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referenceAngle(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.referenceAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointTranslation(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.jointTranslation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointSpeed(IntPtr l) {
		UnityEngine.SliderJoint2D o = (UnityEngine.SliderJoint2D)checkSelf(l);
		pushValue(l,o.jointSpeed);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SliderJoint2D");
		addMember(l,GetMotorForce);
		addMember(l,"angle",get_angle,set_angle,true);
		addMember(l,"useMotor",get_useMotor,set_useMotor,true);
		addMember(l,"useLimits",get_useLimits,set_useLimits,true);
		addMember(l,"motor",get_motor,set_motor,true);
		addMember(l,"limits",get_limits,set_limits,true);
		addMember(l,"limitState",get_limitState,null,true);
		addMember(l,"referenceAngle",get_referenceAngle,null,true);
		addMember(l,"jointTranslation",get_jointTranslation,null,true);
		addMember(l,"jointSpeed",get_jointSpeed,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SliderJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
