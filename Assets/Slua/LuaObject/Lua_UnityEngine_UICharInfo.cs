using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UICharInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cursorPos(IntPtr l) {
		UnityEngine.UICharInfo o = checkSelf<UnityEngine.UICharInfo>(l);
		pushValue(l,o.cursorPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cursorPos(IntPtr l) {
		UnityEngine.UICharInfo o = checkSelf<UnityEngine.UICharInfo>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.cursorPos=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_charWidth(IntPtr l) {
		UnityEngine.UICharInfo o = checkSelf<UnityEngine.UICharInfo>(l);
		pushValue(l,o.charWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_charWidth(IntPtr l) {
		UnityEngine.UICharInfo o = checkSelf<UnityEngine.UICharInfo>(l);
		System.Single v;
		checkType(l,2,out v);
		o.charWidth=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UICharInfo");
		addMember(l,get_cursorPos, "get_cursorPos");
		addMember(l,set_cursorPos, "set_cursorPos");
		addMember(l,get_charWidth, "get_charWidth");
		addMember(l,set_charWidth, "set_charWidth");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UICharInfo));
		LuaDLL.lua_pop(l, 1);
	}
}
