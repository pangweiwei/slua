using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointMotor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetVelocity(IntPtr l) {
		UnityEngine.JointMotor o = checkSelf<UnityEngine.JointMotor>(l);
		pushValue(l,o.targetVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetVelocity(IntPtr l) {
		UnityEngine.JointMotor o = checkSelf<UnityEngine.JointMotor>(l);
		System.Single v;
		checkType(l,2,out v);
		o.targetVelocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		UnityEngine.JointMotor o = checkSelf<UnityEngine.JointMotor>(l);
		pushValue(l,o.force);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		UnityEngine.JointMotor o = checkSelf<UnityEngine.JointMotor>(l);
		System.Single v;
		checkType(l,2,out v);
		o.force=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_freeSpin(IntPtr l) {
		UnityEngine.JointMotor o = checkSelf<UnityEngine.JointMotor>(l);
		pushValue(l,o.freeSpin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_freeSpin(IntPtr l) {
		UnityEngine.JointMotor o = checkSelf<UnityEngine.JointMotor>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.freeSpin=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointMotor");
		addMember(l,get_targetVelocity, "get_targetVelocity");
		addMember(l,set_targetVelocity, "set_targetVelocity");
		addMember(l,get_force, "get_force");
		addMember(l,set_force, "set_force");
		addMember(l,get_freeSpin, "get_freeSpin");
		addMember(l,set_freeSpin, "set_freeSpin");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.JointMotor));
		LuaDLL.lua_pop(l, 1);
	}
}
