using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIItemSlot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_icon(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		pushValue(l,o.icon);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_icon(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		UISprite v;
		checkType(l,2,out v);
		o.icon=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_background(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		pushValue(l,o.background);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_background(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		UIWidget v;
		checkType(l,2,out v);
		o.background=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_label(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		pushValue(l,o.label);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_label(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		UILabel v;
		checkType(l,2,out v);
		o.label=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grabSound(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		pushValue(l,o.grabSound);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_grabSound(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		UnityEngine.AudioClip v;
		checkType(l,2,out v);
		o.grabSound=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_placeSound(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		pushValue(l,o.placeSound);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_placeSound(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		UnityEngine.AudioClip v;
		checkType(l,2,out v);
		o.placeSound=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_errorSound(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		pushValue(l,o.errorSound);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_errorSound(IntPtr l) {
		UIItemSlot o = (UIItemSlot)checkSelf(l);
		UnityEngine.AudioClip v;
		checkType(l,2,out v);
		o.errorSound=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIItemSlot");
		addMember(l,"icon",get_icon,set_icon,true);
		addMember(l,"background",get_background,set_background,true);
		addMember(l,"label",get_label,set_label,true);
		addMember(l,"grabSound",get_grabSound,set_grabSound,true);
		addMember(l,"placeSound",get_placeSound,set_placeSound,true);
		addMember(l,"errorSound",get_errorSound,set_errorSound,true);
		createTypeMetatable(l,constructor, typeof(UIItemSlot),typeof(UnityEngine.MonoBehaviour));
	}
}
