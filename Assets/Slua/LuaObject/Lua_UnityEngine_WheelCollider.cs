using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WheelCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.WheelCollider o;
		if(matchType(l,1)){
			o=new UnityEngine.WheelCollider();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGroundHit(IntPtr l) {
		try{
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			UnityEngine.WheelHit a1;
			System.Boolean ret=self.GetGroundHit(out a1);
			pushValue(l,ret);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_suspensionDistance(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.suspensionDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_suspensionDistance(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.suspensionDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_suspensionSpring(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.suspensionSpring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_suspensionSpring(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		UnityEngine.JointSpring v;
		checkType(l,2,out v);
		o.suspensionSpring=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mass(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.mass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mass(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.mass=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forwardFriction(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.forwardFriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forwardFriction(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		UnityEngine.WheelFrictionCurve v;
		checkType(l,2,out v);
		o.forwardFriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sidewaysFriction(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.sidewaysFriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sidewaysFriction(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		UnityEngine.WheelFrictionCurve v;
		checkType(l,2,out v);
		o.sidewaysFriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motorTorque(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.motorTorque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motorTorque(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.motorTorque=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_brakeTorque(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.brakeTorque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_brakeTorque(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.brakeTorque=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_steerAngle(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.steerAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_steerAngle(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.steerAngle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isGrounded(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.isGrounded);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rpm(IntPtr l) {
		UnityEngine.WheelCollider o = (UnityEngine.WheelCollider)checkSelf(l);
		pushValue(l,o.rpm);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WheelCollider");
		addMember(l,GetGroundHit);
		addMember(l,"center",get_center,set_center);
		addMember(l,"radius",get_radius,set_radius);
		addMember(l,"suspensionDistance",get_suspensionDistance,set_suspensionDistance);
		addMember(l,"suspensionSpring",get_suspensionSpring,set_suspensionSpring);
		addMember(l,"mass",get_mass,set_mass);
		addMember(l,"forwardFriction",get_forwardFriction,set_forwardFriction);
		addMember(l,"sidewaysFriction",get_sidewaysFriction,set_sidewaysFriction);
		addMember(l,"motorTorque",get_motorTorque,set_motorTorque);
		addMember(l,"brakeTorque",get_brakeTorque,set_brakeTorque);
		addMember(l,"steerAngle",get_steerAngle,set_steerAngle);
		addMember(l,"isGrounded",get_isGrounded,null);
		addMember(l,"rpm",get_rpm,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WheelCollider),typeof(UnityEngine.Collider));
	}
}
