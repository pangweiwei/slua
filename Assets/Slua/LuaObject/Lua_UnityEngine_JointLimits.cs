using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointLimits : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minBounce(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		pushValue(l,o.minBounce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minBounce(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minBounce=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxBounce(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		pushValue(l,o.maxBounce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxBounce(IntPtr l) {
		UnityEngine.JointLimits o = (UnityEngine.JointLimits)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxBounce=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointLimits");
		addMember(l,"min",get_min,set_min,true);
		addMember(l,"minBounce",get_minBounce,set_minBounce,true);
		addMember(l,"max",get_max,set_max,true);
		addMember(l,"maxBounce",get_maxBounce,set_maxBounce,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointLimits));
	}
}
