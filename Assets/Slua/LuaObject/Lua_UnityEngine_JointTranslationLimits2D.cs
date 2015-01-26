using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointTranslationLimits2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		UnityEngine.JointTranslationLimits2D o = (UnityEngine.JointTranslationLimits2D)checkSelf(l);
		pushValue(l,o.min);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		UnityEngine.JointTranslationLimits2D o = (UnityEngine.JointTranslationLimits2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.min=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		UnityEngine.JointTranslationLimits2D o = (UnityEngine.JointTranslationLimits2D)checkSelf(l);
		pushValue(l,o.max);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		UnityEngine.JointTranslationLimits2D o = (UnityEngine.JointTranslationLimits2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.max=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointTranslationLimits2D");
		addMember(l,"min",get_min,set_min);
		addMember(l,"max",get_max,set_max);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointTranslationLimits2D));
	}
}
