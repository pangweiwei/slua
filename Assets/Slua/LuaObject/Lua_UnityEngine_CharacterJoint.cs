using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CharacterJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.CharacterJoint o;
		o=new UnityEngine.CharacterJoint();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swingAxis(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.swingAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swingAxis(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.swingAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_twistLimitSpring(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.twistLimitSpring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_twistLimitSpring(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.SoftJointLimitSpring v;
		checkType(l,2,out v);
		o.twistLimitSpring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swingLimitSpring(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.swingLimitSpring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swingLimitSpring(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.SoftJointLimitSpring v;
		checkType(l,2,out v);
		o.swingLimitSpring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.lowTwistLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.lowTwistLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.highTwistLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.highTwistLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swing1Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.swing1Limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swing1Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.swing1Limit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swing2Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.swing2Limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swing2Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.swing2Limit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableProjection(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.enableProjection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableProjection(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enableProjection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionDistance(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.projectionDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionDistance(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.projectionDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionAngle(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.projectionAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionAngle(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.projectionAngle=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterJoint");
		addMember(l,"swingAxis",get_swingAxis,set_swingAxis,true);
		addMember(l,"twistLimitSpring",get_twistLimitSpring,set_twistLimitSpring,true);
		addMember(l,"swingLimitSpring",get_swingLimitSpring,set_swingLimitSpring,true);
		addMember(l,"lowTwistLimit",get_lowTwistLimit,set_lowTwistLimit,true);
		addMember(l,"highTwistLimit",get_highTwistLimit,set_highTwistLimit,true);
		addMember(l,"swing1Limit",get_swing1Limit,set_swing1Limit,true);
		addMember(l,"swing2Limit",get_swing2Limit,set_swing2Limit,true);
		addMember(l,"enableProjection",get_enableProjection,set_enableProjection,true);
		addMember(l,"projectionDistance",get_projectionDistance,set_projectionDistance,true);
		addMember(l,"projectionAngle",get_projectionAngle,set_projectionAngle,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CharacterJoint),typeof(UnityEngine.Joint));
	}
}
