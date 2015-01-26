using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointMotor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetVelocity(IntPtr l) {
		UnityEngine.JointMotor o = (UnityEngine.JointMotor)checkSelf(l);
		pushValue(l,o.targetVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetVelocity(IntPtr l) {
		UnityEngine.JointMotor o = (UnityEngine.JointMotor)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.targetVelocity=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		UnityEngine.JointMotor o = (UnityEngine.JointMotor)checkSelf(l);
		pushValue(l,o.force);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		UnityEngine.JointMotor o = (UnityEngine.JointMotor)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.force=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_freeSpin(IntPtr l) {
		UnityEngine.JointMotor o = (UnityEngine.JointMotor)checkSelf(l);
		pushValue(l,o.freeSpin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_freeSpin(IntPtr l) {
		UnityEngine.JointMotor o = (UnityEngine.JointMotor)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.freeSpin=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointMotor");
		addMember(l,"targetVelocity",get_targetVelocity,set_targetVelocity);
		addMember(l,"force",get_force,set_force);
		addMember(l,"freeSpin",get_freeSpin,set_freeSpin);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointMotor));
	}
}
