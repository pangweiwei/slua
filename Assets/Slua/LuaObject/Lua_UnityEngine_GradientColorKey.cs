using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GradientColorKey : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.GradientColorKey o;
		if(matchType(l,1,typeof(UnityEngine.Color),typeof(System.Single))){
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.GradientColorKey(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.GradientColorKey o = checkSelf<UnityEngine.GradientColorKey>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.GradientColorKey o = checkSelf<UnityEngine.GradientColorKey>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.GradientColorKey o = checkSelf<UnityEngine.GradientColorKey>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.GradientColorKey o = checkSelf<UnityEngine.GradientColorKey>(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GradientColorKey");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_time, "get_time");
		addMember(l,set_time, "set_time");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.GradientColorKey));
		LuaDLL.lua_pop(l, 1);
	}
}
