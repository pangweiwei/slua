using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UILineInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startCharIdx(IntPtr l) {
		UnityEngine.UILineInfo o = (UnityEngine.UILineInfo)checkSelf(l);
		pushValue(l,o.startCharIdx);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startCharIdx(IntPtr l) {
		UnityEngine.UILineInfo o = (UnityEngine.UILineInfo)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.startCharIdx=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.UILineInfo o = (UnityEngine.UILineInfo)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.UILineInfo o = (UnityEngine.UILineInfo)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.height=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UILineInfo");
		addMember(l,"startCharIdx",get_startCharIdx,set_startCharIdx);
		addMember(l,"height",get_height,set_height);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UILineInfo));
	}
}
