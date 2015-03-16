using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ColorBlock : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		pushValue(l,o.normalColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.normalColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		pushValue(l,o.highlightedColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.highlightedColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		pushValue(l,o.pressedColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.pressedColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		pushValue(l,o.disabledColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledColor(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.disabledColor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorMultiplier(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		pushValue(l,o.colorMultiplier);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorMultiplier(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.colorMultiplier=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fadeDuration(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		pushValue(l,o.fadeDuration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fadeDuration(IntPtr l) {
		UnityEngine.UI.ColorBlock o = (UnityEngine.UI.ColorBlock)checkSelf(l);
		float v;
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
		addMember(l,"normalColor",get_normalColor,set_normalColor,true);
		addMember(l,"highlightedColor",get_highlightedColor,set_highlightedColor,true);
		addMember(l,"pressedColor",get_pressedColor,set_pressedColor,true);
		addMember(l,"disabledColor",get_disabledColor,set_disabledColor,true);
		addMember(l,"colorMultiplier",get_colorMultiplier,set_colorMultiplier,true);
		addMember(l,"fadeDuration",get_fadeDuration,set_fadeDuration,true);
		addMember(l,"defaultColorBlock",get_defaultColorBlock,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.ColorBlock));
	}
}
