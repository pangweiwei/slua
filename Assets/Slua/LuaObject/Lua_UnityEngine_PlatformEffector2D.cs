using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PlatformEffector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.PlatformEffector2D o;
		o=new UnityEngine.PlatformEffector2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_oneWay(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,o.oneWay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_oneWay(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.oneWay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sideFriction(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,o.sideFriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sideFriction(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.sideFriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sideBounce(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,o.sideBounce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sideBounce(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.sideBounce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sideAngleVariance(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		pushValue(l,o.sideAngleVariance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sideAngleVariance(IntPtr l) {
		UnityEngine.PlatformEffector2D o = (UnityEngine.PlatformEffector2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.sideAngleVariance=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlatformEffector2D");
		addMember(l,"oneWay",get_oneWay,set_oneWay,true);
		addMember(l,"sideFriction",get_sideFriction,set_sideFriction,true);
		addMember(l,"sideBounce",get_sideBounce,set_sideBounce,true);
		addMember(l,"sideAngleVariance",get_sideAngleVariance,set_sideAngleVariance,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlatformEffector2D),typeof(UnityEngine.Effector2D));
	}
}
