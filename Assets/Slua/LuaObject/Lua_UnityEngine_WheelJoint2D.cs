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
			UnityEngine.WheelJoint2D self=checkSelf<UnityEngine.WheelJoint2D>(l);
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
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		pushValue(l,o.suspension);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_suspension(IntPtr l) {
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		UnityEngine.JointSuspension2D v;
		checkType(l,2,out v);
		o.suspension=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMotor(IntPtr l) {
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		pushValue(l,o.useMotor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMotor(IntPtr l) {
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useMotor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motor(IntPtr l) {
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		pushValue(l,o.motor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motor(IntPtr l) {
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		UnityEngine.JointMotor2D v;
		checkType(l,2,out v);
		o.motor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointTranslation(IntPtr l) {
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		pushValue(l,o.jointTranslation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_jointSpeed(IntPtr l) {
		UnityEngine.WheelJoint2D o = checkSelf<UnityEngine.WheelJoint2D>(l);
		pushValue(l,o.jointSpeed);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WheelJoint2D");
		addMember(l,GetMotorTorque, "GetMotorTorque");
		addMember(l,get_suspension, "get_suspension");
		addMember(l,set_suspension, "set_suspension");
		addMember(l,get_useMotor, "get_useMotor");
		addMember(l,set_useMotor, "set_useMotor");
		addMember(l,get_motor, "get_motor");
		addMember(l,set_motor, "set_motor");
		addMember(l,get_jointTranslation, "get_jointTranslation");
		addMember(l,get_jointSpeed, "get_jointSpeed");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.WheelJoint2D),typeof(UnityEngine.AnchoredJoint2D));
		LuaDLL.lua_pop(l, 1);
	}
}
