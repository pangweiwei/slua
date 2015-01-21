using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WheelJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.WheelJoint2D o;
		if(matchType(l,1)){
			o=new UnityEngine.WheelJoint2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMotorTorque(IntPtr l) {
		try{
			UnityEngine.WheelJoint2D self=(UnityEngine.WheelJoint2D)checkSelf(l);
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
	static public int get_suspension(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		pushValue(l,o.suspension);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_suspension(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		UnityEngine.JointSuspension2D v;
		checkType(l,2,out v);
		o.suspension=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMotor(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		pushValue(l,o.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		pushValue(l,o.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		UnityEngine.JointMotor2D v;
		checkType(l,2,out v);
		o.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointTranslation(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		pushValue(l,o.jointTranslation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointSpeed(IntPtr l) {
		UnityEngine.WheelJoint2D o = (UnityEngine.WheelJoint2D)checkSelf(l);
		pushValue(l,o.jointSpeed);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WheelJoint2D");
		addMember(l,GetMotorTorque);
		addMember(l,"suspension",get_suspension,set_suspension);
		addMember(l,"useMotor",get_useMotor,set_useMotor);
		addMember(l,"motor",get_motor,set_motor);
		addMember(l,"jointTranslation",get_jointTranslation,null);
		addMember(l,"jointSpeed",get_jointSpeed,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WheelJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
