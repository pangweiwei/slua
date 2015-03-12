﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ConfigurableJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ConfigurableJoint o;
		o=new UnityEngine.ConfigurableJoint();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_secondaryAxis(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.secondaryAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_secondaryAxis(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.secondaryAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.xMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.xMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.yMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.yMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.zMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_zMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.zMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularXMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.angularXMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularXMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.angularXMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularYMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.angularYMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularYMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.angularYMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularZMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.angularZMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularZMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.angularZMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linearLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.linearLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linearLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.linearLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.lowAngularXLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.lowAngularXLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.highAngularXLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.highAngularXLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularYLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.angularYLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularYLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.angularYLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularZLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.angularZLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularZLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.angularZLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetPosition(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.targetPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetPosition(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.targetVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.xDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.xDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.yDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.yDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.zDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_zDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.zDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRotation(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.targetRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetRotation(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.targetRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetAngularVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.targetAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetAngularVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationDriveMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.rotationDriveMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationDriveMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.RotationDriveMode v;
		checkEnum(l,2,out v);
		o.rotationDriveMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularXDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.angularXDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularXDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.angularXDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularYZDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.angularYZDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularYZDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.angularYZDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slerpDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.slerpDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_slerpDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.slerpDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushEnum(l,(int)o.projectionMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		UnityEngine.JointProjectionMode v;
		checkEnum(l,2,out v);
		o.projectionMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionDistance(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.projectionDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionDistance(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.projectionDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionAngle(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.projectionAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionAngle(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.projectionAngle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_configuredInWorldSpace(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.configuredInWorldSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_configuredInWorldSpace(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.configuredInWorldSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swapBodies(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		pushValue(l,o.swapBodies);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swapBodies(IntPtr l) {
		UnityEngine.ConfigurableJoint o = (UnityEngine.ConfigurableJoint)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.swapBodies=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ConfigurableJoint");
		addMember(l,"secondaryAxis",get_secondaryAxis,set_secondaryAxis,true);
		addMember(l,"xMotion",get_xMotion,set_xMotion,true);
		addMember(l,"yMotion",get_yMotion,set_yMotion,true);
		addMember(l,"zMotion",get_zMotion,set_zMotion,true);
		addMember(l,"angularXMotion",get_angularXMotion,set_angularXMotion,true);
		addMember(l,"angularYMotion",get_angularYMotion,set_angularYMotion,true);
		addMember(l,"angularZMotion",get_angularZMotion,set_angularZMotion,true);
		addMember(l,"linearLimit",get_linearLimit,set_linearLimit,true);
		addMember(l,"lowAngularXLimit",get_lowAngularXLimit,set_lowAngularXLimit,true);
		addMember(l,"highAngularXLimit",get_highAngularXLimit,set_highAngularXLimit,true);
		addMember(l,"angularYLimit",get_angularYLimit,set_angularYLimit,true);
		addMember(l,"angularZLimit",get_angularZLimit,set_angularZLimit,true);
		addMember(l,"targetPosition",get_targetPosition,set_targetPosition,true);
		addMember(l,"targetVelocity",get_targetVelocity,set_targetVelocity,true);
		addMember(l,"xDrive",get_xDrive,set_xDrive,true);
		addMember(l,"yDrive",get_yDrive,set_yDrive,true);
		addMember(l,"zDrive",get_zDrive,set_zDrive,true);
		addMember(l,"targetRotation",get_targetRotation,set_targetRotation,true);
		addMember(l,"targetAngularVelocity",get_targetAngularVelocity,set_targetAngularVelocity,true);
		addMember(l,"rotationDriveMode",get_rotationDriveMode,set_rotationDriveMode,true);
		addMember(l,"angularXDrive",get_angularXDrive,set_angularXDrive,true);
		addMember(l,"angularYZDrive",get_angularYZDrive,set_angularYZDrive,true);
		addMember(l,"slerpDrive",get_slerpDrive,set_slerpDrive,true);
		addMember(l,"projectionMode",get_projectionMode,set_projectionMode,true);
		addMember(l,"projectionDistance",get_projectionDistance,set_projectionDistance,true);
		addMember(l,"projectionAngle",get_projectionAngle,set_projectionAngle,true);
		addMember(l,"configuredInWorldSpace",get_configuredInWorldSpace,set_configuredInWorldSpace,true);
		addMember(l,"swapBodies",get_swapBodies,set_swapBodies,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ConfigurableJoint),typeof(UnityEngine.Joint));
	}
}
