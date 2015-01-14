using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SoftJointLimit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limit(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		pushValue(l,o.limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limit(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		System.Single v;
		checkType(l,2,out v);
		o.limit=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spring(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		pushValue(l,o.spring);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spring(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		System.Single v;
		checkType(l,2,out v);
		o.spring=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damper(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		pushValue(l,o.damper);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damper(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		System.Single v;
		checkType(l,2,out v);
		o.damper=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounciness(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		pushValue(l,o.bounciness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounciness(IntPtr l) {
		UnityEngine.SoftJointLimit o = checkSelf<UnityEngine.SoftJointLimit>(l);
		System.Single v;
		checkType(l,2,out v);
		o.bounciness=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SoftJointLimit");
		addMember(l,get_limit, "get_limit");
		addMember(l,set_limit, "set_limit");
		addMember(l,get_spring, "get_spring");
		addMember(l,set_spring, "set_spring");
		addMember(l,get_damper, "get_damper");
		addMember(l,set_damper, "set_damper");
		addMember(l,get_bounciness, "get_bounciness");
		addMember(l,set_bounciness, "set_bounciness");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.SoftJointLimit));
		LuaDLL.lua_pop(l, 1);
	}
}
