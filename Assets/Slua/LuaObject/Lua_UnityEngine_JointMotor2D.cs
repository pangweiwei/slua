using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointMotor2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motorSpeed(IntPtr l) {
		UnityEngine.JointMotor2D o = (UnityEngine.JointMotor2D)checkSelf(l);
		pushValue(l,o.motorSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motorSpeed(IntPtr l) {
		UnityEngine.JointMotor2D o = (UnityEngine.JointMotor2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.motorSpeed=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxMotorTorque(IntPtr l) {
		UnityEngine.JointMotor2D o = (UnityEngine.JointMotor2D)checkSelf(l);
		pushValue(l,o.maxMotorTorque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxMotorTorque(IntPtr l) {
		UnityEngine.JointMotor2D o = (UnityEngine.JointMotor2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxMotorTorque=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointMotor2D");
		addMember(l,"motorSpeed",get_motorSpeed,set_motorSpeed);
		addMember(l,"maxMotorTorque",get_maxMotorTorque,set_maxMotorTorque);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointMotor2D));
	}
}
