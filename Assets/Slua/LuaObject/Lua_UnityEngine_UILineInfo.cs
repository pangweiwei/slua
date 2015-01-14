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
		UnityEngine.UILineInfo o = checkSelf<UnityEngine.UILineInfo>(l);
		pushValue(l,o.startCharIdx);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startCharIdx(IntPtr l) {
		UnityEngine.UILineInfo o = checkSelf<UnityEngine.UILineInfo>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.startCharIdx=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.UILineInfo o = checkSelf<UnityEngine.UILineInfo>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.UILineInfo o = checkSelf<UnityEngine.UILineInfo>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.height=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UILineInfo");
		addMember(l,get_startCharIdx, "get_startCharIdx");
		addMember(l,set_startCharIdx, "set_startCharIdx");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UILineInfo));
		LuaDLL.lua_pop(l, 1);
	}
}
