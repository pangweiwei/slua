using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UICharInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cursorPos(IntPtr l) {
		UnityEngine.UICharInfo o = (UnityEngine.UICharInfo)checkSelf(l);
		pushValue(l,o.cursorPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cursorPos(IntPtr l) {
		UnityEngine.UICharInfo o = (UnityEngine.UICharInfo)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.cursorPos=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_charWidth(IntPtr l) {
		UnityEngine.UICharInfo o = (UnityEngine.UICharInfo)checkSelf(l);
		pushValue(l,o.charWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_charWidth(IntPtr l) {
		UnityEngine.UICharInfo o = (UnityEngine.UICharInfo)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.charWidth=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UICharInfo");
		addMember(l,"cursorPos",get_cursorPos,set_cursorPos,true);
		addMember(l,"charWidth",get_charWidth,set_charWidth,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UICharInfo));
	}
}
