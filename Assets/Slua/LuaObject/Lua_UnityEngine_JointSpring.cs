using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointSpring : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spring(IntPtr l) {
		UnityEngine.JointSpring o = (UnityEngine.JointSpring)checkSelf(l);
		pushValue(l,o.spring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spring(IntPtr l) {
		UnityEngine.JointSpring o = (UnityEngine.JointSpring)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.spring=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damper(IntPtr l) {
		UnityEngine.JointSpring o = (UnityEngine.JointSpring)checkSelf(l);
		pushValue(l,o.damper);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damper(IntPtr l) {
		UnityEngine.JointSpring o = (UnityEngine.JointSpring)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.damper=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetPosition(IntPtr l) {
		UnityEngine.JointSpring o = (UnityEngine.JointSpring)checkSelf(l);
		pushValue(l,o.targetPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetPosition(IntPtr l) {
		UnityEngine.JointSpring o = (UnityEngine.JointSpring)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.targetPosition=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointSpring");
		addMember(l,"spring",get_spring,set_spring);
		addMember(l,"damper",get_damper,set_damper);
		addMember(l,"targetPosition",get_targetPosition,set_targetPosition);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointSpring));
	}
}
