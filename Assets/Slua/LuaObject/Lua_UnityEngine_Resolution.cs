using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Resolution : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.Resolution o = checkSelf<UnityEngine.Resolution>(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.Resolution o = checkSelf<UnityEngine.Resolution>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.width=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.Resolution o = checkSelf<UnityEngine.Resolution>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.Resolution o = checkSelf<UnityEngine.Resolution>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.height=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_refreshRate(IntPtr l) {
		UnityEngine.Resolution o = checkSelf<UnityEngine.Resolution>(l);
		pushValue(l,o.refreshRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_refreshRate(IntPtr l) {
		UnityEngine.Resolution o = checkSelf<UnityEngine.Resolution>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.refreshRate=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Resolution");
		addMember(l,get_width, "get_width");
		addMember(l,set_width, "set_width");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_refreshRate, "get_refreshRate");
		addMember(l,set_refreshRate, "set_refreshRate");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Resolution));
		LuaDLL.lua_pop(l, 1);
	}
}
