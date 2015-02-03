using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonColor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIButtonColor o;
		o=new UIButtonColor();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenTarget(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		pushValue(l,o.tweenTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenTarget(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.tweenTarget=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hover(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		pushValue(l,o.hover);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hover(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.hover=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressed(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		pushValue(l,o.pressed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressed(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.pressed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledColor(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		pushValue(l,o.disabledColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledColor(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.disabledColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_duration(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		pushValue(l,o.duration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_duration(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.duration=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultColor(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		pushValue(l,o.defaultColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultColor(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.defaultColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEnabled(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		pushValue(l,o.isEnabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isEnabled(IntPtr l) {
		UIButtonColor o = (UIButtonColor)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isEnabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButtonColor");
		addMember(l,"tweenTarget",get_tweenTarget,set_tweenTarget,true);
		addMember(l,"hover",get_hover,set_hover,true);
		addMember(l,"pressed",get_pressed,set_pressed,true);
		addMember(l,"disabledColor",get_disabledColor,set_disabledColor,true);
		addMember(l,"duration",get_duration,set_duration,true);
		addMember(l,"defaultColor",get_defaultColor,set_defaultColor,true);
		addMember(l,"isEnabled",get_isEnabled,set_isEnabled,true);
		createTypeMetatable(l,constructor, typeof(UIButtonColor),typeof(UIWidgetContainer));
	}
}
