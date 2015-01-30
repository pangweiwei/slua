using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CharacterJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.CharacterJoint o;
		if(matchType(l,1)){
			o=new UnityEngine.CharacterJoint();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
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
	static public int get_targetRotation(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.targetRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetRotation(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.targetRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetAngularVelocity(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.targetAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetAngularVelocity(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationDrive(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		pushValue(l,o.rotationDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationDrive(IntPtr l) {
		UnityEngine.CharacterJoint o = (UnityEngine.CharacterJoint)checkSelf(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.rotationDrive=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterJoint");
		addMember(l,"swingAxis",get_swingAxis,set_swingAxis,true);
		addMember(l,"lowTwistLimit",get_lowTwistLimit,set_lowTwistLimit,true);
		addMember(l,"highTwistLimit",get_highTwistLimit,set_highTwistLimit,true);
		addMember(l,"swing1Limit",get_swing1Limit,set_swing1Limit,true);
		addMember(l,"swing2Limit",get_swing2Limit,set_swing2Limit,true);
		addMember(l,"targetRotation",get_targetRotation,set_targetRotation,true);
		addMember(l,"targetAngularVelocity",get_targetAngularVelocity,set_targetAngularVelocity,true);
		addMember(l,"rotationDrive",get_rotationDrive,set_rotationDrive,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CharacterJoint),typeof(UnityEngine.Joint));
	}
}
