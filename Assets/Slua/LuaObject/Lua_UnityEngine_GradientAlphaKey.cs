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
		if(matchType(l,1,typeof(float),typeof(float))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.GradientAlphaKey(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		UnityEngine.GradientAlphaKey o = (UnityEngine.GradientAlphaKey)checkSelf(l);
		pushValue(l,o.alpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		UnityEngine.GradientAlphaKey o = (UnityEngine.GradientAlphaKey)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.alpha=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.GradientAlphaKey o = (UnityEngine.GradientAlphaKey)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.GradientAlphaKey o = (UnityEngine.GradientAlphaKey)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GradientAlphaKey");
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"time",get_time,set_time,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GradientAlphaKey));
	}
}
