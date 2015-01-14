using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ColorBlock : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		pushValue(l,o.normalColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.normalColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		pushValue(l,o.highlightedColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.highlightedColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		pushValue(l,o.pressedColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.pressedColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		pushValue(l,o.disabledColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.disabledColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorMultiplier(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		pushValue(l,o.colorMultiplier);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorMultiplier(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		System.Single v;
		checkType(l,2,out v);
		o.colorMultiplier=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fadeDuration(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		pushValue(l,o.fadeDuration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fadeDuration(IntPtr l) {
		UnityEngine.UI.ColorBlock o = checkSelf<UnityEngine.UI.ColorBlock>(l);
		System.Single v;
		checkType(l,2,out v);
		o.fadeDuration=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultColorBlock(IntPtr l) {
		pushValue(l,UnityEngine.UI.ColorBlock.defaultColorBlock);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ColorBlock");
		addMember(l,get_normalColor, "get_normalColor");
		addMember(l,set_normalColor, "set_normalColor");
		addMember(l,get_highlightedColor, "get_highlightedColor");
		addMember(l,set_highlightedColor, "set_highlightedColor");
		addMember(l,get_pressedColor, "get_pressedColor");
		addMember(l,set_pressedColor, "set_pressedColor");
		addMember(l,get_disabledColor, "get_disabledColor");
		addMember(l,set_disabledColor, "set_disabledColor");
		addMember(l,get_colorMultiplier, "get_colorMultiplier");
		addMember(l,set_colorMultiplier, "set_colorMultiplier");
		addMember(l,get_fadeDuration, "get_fadeDuration");
		addMember(l,set_fadeDuration, "set_fadeDuration");
		addMember(l,get_defaultColorBlock, "get_defaultColorBlock");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.ColorBlock));
		LuaDLL.lua_pop(l, 1);
	}
}
