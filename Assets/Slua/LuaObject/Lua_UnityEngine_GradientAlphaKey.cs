using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GradientAlphaKey : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.GradientAlphaKey o;
		if(matchType(l,1,typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.GradientAlphaKey(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		UnityEngine.GradientAlphaKey o = checkSelf<UnityEngine.GradientAlphaKey>(l);
		pushValue(l,o.alpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		UnityEngine.GradientAlphaKey o = checkSelf<UnityEngine.GradientAlphaKey>(l);
		System.Single v;
		checkType(l,2,out v);
		o.alpha=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.GradientAlphaKey o = checkSelf<UnityEngine.GradientAlphaKey>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.GradientAlphaKey o = checkSelf<UnityEngine.GradientAlphaKey>(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GradientAlphaKey");
		addMember(l,get_alpha, "get_alpha");
		addMember(l,set_alpha, "set_alpha");
		addMember(l,get_time, "get_time");
		addMember(l,set_time, "set_time");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.GradientAlphaKey));
		LuaDLL.lua_pop(l, 1);
	}
}
