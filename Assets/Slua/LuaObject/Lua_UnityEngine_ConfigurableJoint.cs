using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ConfigurableJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ConfigurableJoint o;
		if(matchType(l,1)){
			o=new UnityEngine.ConfigurableJoint();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_secondaryAxis(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.secondaryAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_secondaryAxis(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.secondaryAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.xMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.xMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.yMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.yMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.zMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_zMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.zMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularXMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.angularXMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularXMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.angularXMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularYMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.angularYMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularYMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.angularYMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularZMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.angularZMotion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularZMotion(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.ConfigurableJointMotion v;
		checkEnum(l,2,out v);
		o.angularZMotion=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linearLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.linearLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linearLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.linearLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.lowAngularXLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.lowAngularXLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.highAngularXLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highAngularXLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.highAngularXLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularYLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.angularYLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularYLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.angularYLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularZLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.angularZLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularZLimit(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.SoftJointLimit v;
		checkType(l,2,out v);
		o.angularZLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetPosition(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.targetPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetPosition(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.targetVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_xDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.xDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_xDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.xDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.yDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.yDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_zDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.zDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_zDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.zDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRotation(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.targetRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetRotation(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.targetRotation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetAngularVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.targetAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetAngularVelocity(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.targetAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationDriveMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.rotationDriveMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotationDriveMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.RotationDriveMode v;
		checkEnum(l,2,out v);
		o.rotationDriveMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularXDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.angularXDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularXDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.angularXDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularYZDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.angularYZDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularYZDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.angularYZDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slerpDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.slerpDrive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_slerpDrive(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.JointDrive v;
		checkType(l,2,out v);
		o.slerpDrive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.projectionMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionMode(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		UnityEngine.JointProjectionMode v;
		checkEnum(l,2,out v);
		o.projectionMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionDistance(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.projectionDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionDistance(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		System.Single v;
		checkType(l,2,out v);
		o.projectionDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_projectionAngle(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.projectionAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_projectionAngle(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		System.Single v;
		checkType(l,2,out v);
		o.projectionAngle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_configuredInWorldSpace(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.configuredInWorldSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_configuredInWorldSpace(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.configuredInWorldSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_swapBodies(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		pushValue(l,o.swapBodies);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_swapBodies(IntPtr l) {
		UnityEngine.ConfigurableJoint o = checkSelf<UnityEngine.ConfigurableJoint>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.swapBodies=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ConfigurableJoint");
		addMember(l,get_secondaryAxis, "get_secondaryAxis");
		addMember(l,set_secondaryAxis, "set_secondaryAxis");
		addMember(l,get_xMotion, "get_xMotion");
		addMember(l,set_xMotion, "set_xMotion");
		addMember(l,get_yMotion, "get_yMotion");
		addMember(l,set_yMotion, "set_yMotion");
		addMember(l,get_zMotion, "get_zMotion");
		addMember(l,set_zMotion, "set_zMotion");
		addMember(l,get_angularXMotion, "get_angularXMotion");
		addMember(l,set_angularXMotion, "set_angularXMotion");
		addMember(l,get_angularYMotion, "get_angularYMotion");
		addMember(l,set_angularYMotion, "set_angularYMotion");
		addMember(l,get_angularZMotion, "get_angularZMotion");
		addMember(l,set_angularZMotion, "set_angularZMotion");
		addMember(l,get_linearLimit, "get_linearLimit");
		addMember(l,set_linearLimit, "set_linearLimit");
		addMember(l,get_lowAngularXLimit, "get_lowAngularXLimit");
		addMember(l,set_lowAngularXLimit, "set_lowAngularXLimit");
		addMember(l,get_highAngularXLimit, "get_highAngularXLimit");
		addMember(l,set_highAngularXLimit, "set_highAngularXLimit");
		addMember(l,get_angularYLimit, "get_angularYLimit");
		addMember(l,set_angularYLimit, "set_angularYLimit");
		addMember(l,get_angularZLimit, "get_angularZLimit");
		addMember(l,set_angularZLimit, "set_angularZLimit");
		addMember(l,get_targetPosition, "get_targetPosition");
		addMember(l,set_targetPosition, "set_targetPosition");
		addMember(l,get_targetVelocity, "get_targetVelocity");
		addMember(l,set_targetVelocity, "set_targetVelocity");
		addMember(l,get_xDrive, "get_xDrive");
		addMember(l,set_xDrive, "set_xDrive");
		addMember(l,get_yDrive, "get_yDrive");
		addMember(l,set_yDrive, "set_yDrive");
		addMember(l,get_zDrive, "get_zDrive");
		addMember(l,set_zDrive, "set_zDrive");
		addMember(l,get_targetRotation, "get_targetRotation");
		addMember(l,set_targetRotation, "set_targetRotation");
		addMember(l,get_targetAngularVelocity, "get_targetAngularVelocity");
		addMember(l,set_targetAngularVelocity, "set_targetAngularVelocity");
		addMember(l,get_rotationDriveMode, "get_rotationDriveMode");
		addMember(l,set_rotationDriveMode, "set_rotationDriveMode");
		addMember(l,get_angularXDrive, "get_angularXDrive");
		addMember(l,set_angularXDrive, "set_angularXDrive");
		addMember(l,get_angularYZDrive, "get_angularYZDrive");
		addMember(l,set_angularYZDrive, "set_angularYZDrive");
		addMember(l,get_slerpDrive, "get_slerpDrive");
		addMember(l,set_slerpDrive, "set_slerpDrive");
		addMember(l,get_projectionMode, "get_projectionMode");
		addMember(l,set_projectionMode, "set_projectionMode");
		addMember(l,get_projectionDistance, "get_projectionDistance");
		addMember(l,set_projectionDistance, "set_projectionDistance");
		addMember(l,get_projectionAngle, "get_projectionAngle");
		addMember(l,set_projectionAngle, "set_projectionAngle");
		addMember(l,get_configuredInWorldSpace, "get_configuredInWorldSpace");
		addMember(l,set_configuredInWorldSpace, "set_configuredInWorldSpace");
		addMember(l,get_swapBodies, "get_swapBodies");
		addMember(l,set_swapBodies, "set_swapBodies");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ConfigurableJoint),typeof(UnityEngine.Joint));
		LuaDLL.lua_pop(l, 1);
	}
}
