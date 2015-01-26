using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Resolution : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.Resolution o = (UnityEngine.Resolution)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.Resolution o = (UnityEngine.Resolution)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.width=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.Resolution o = (UnityEngine.Resolution)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.Resolution o = (UnityEngine.Resolution)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.height=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_refreshRate(IntPtr l) {
		UnityEngine.Resolution o = (UnityEngine.Resolution)checkSelf(l);
		pushValue(l,o.refreshRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_refreshRate(IntPtr l) {
		UnityEngine.Resolution o = (UnityEngine.Resolution)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.refreshRate=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Resolution");
		addMember(l,"width",get_width,set_width);
		addMember(l,"height",get_height,set_height);
		addMember(l,"refreshRate",get_refreshRate,set_refreshRate);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Resolution));
	}
}
