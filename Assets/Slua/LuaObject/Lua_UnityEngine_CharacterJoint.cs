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
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swingAxis(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.swingAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swingAxis(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.swingAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.lowTwistLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.lowTwistLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.highTwistLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highTwistLimit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.highTwistLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swing1Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.swing1Limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swing1Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.swing1Limit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swing2Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.swing2Limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swing2Limit(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.swing2Limit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRotation(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.targetRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetRotation(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.targetRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetAngularVelocity(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.targetAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetAngularVelocity(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationDrive(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		pushValue(l,o.rotationDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationDrive(IntPtr l) {
		UnityEngine.CharacterJoint o = checkSelf<UnityEngine.CharacterJoint>(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.rotationDrive=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterJoint");
		addMember(l,get_swingAxis, "get_swingAxis");
		addMember(l,set_swingAxis, "set_swingAxis");
		addMember(l,get_lowTwistLimit, "get_lowTwistLimit");
		addMember(l,set_lowTwistLimit, "set_lowTwistLimit");
		addMember(l,get_highTwistLimit, "get_highTwistLimit");
		addMember(l,set_highTwistLimit, "set_highTwistLimit");
		addMember(l,get_swing1Limit, "get_swing1Limit");
		addMember(l,set_swing1Limit, "set_swing1Limit");
		addMember(l,get_swing2Limit, "get_swing2Limit");
		addMember(l,set_swing2Limit, "set_swing2Limit");
		addMember(l,get_targetRotation, "get_targetRotation");
		addMember(l,set_targetRotation, "set_targetRotation");
		addMember(l,get_targetAngularVelocity, "get_targetAngularVelocity");
		addMember(l,set_targetAngularVelocity, "set_targetAngularVelocity");
		addMember(l,get_rotationDrive, "get_rotationDrive");
		addMember(l,set_rotationDrive, "set_rotationDrive");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.CharacterJoint),typeof(UnityEngine.Joint));
		LuaDLL.lua_pop(l, 1);
	}
}
