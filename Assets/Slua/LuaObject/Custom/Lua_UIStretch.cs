using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIStretch : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIStretch o;
		o=new UIStretch();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		pushValue(l,o.uiCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiCamera(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.uiCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_container(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		pushValue(l,o.container);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_container(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.container=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_style(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		pushEnum(l,(int)o.style);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_style(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		UIStretch.Style v;
		checkEnum(l,2,out v);
		o.style=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runOnlyOnce(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		pushValue(l,o.runOnlyOnce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runOnlyOnce(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.runOnlyOnce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeSize(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		pushValue(l,o.relativeSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relativeSize(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.relativeSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_initialSize(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		pushValue(l,o.initialSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_initialSize(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.initialSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderPadding(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		pushValue(l,o.borderPadding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderPadding(IntPtr l) {
		UIStretch o = (UIStretch)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.borderPadding=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIStretch");
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"container",get_container,set_container,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"runOnlyOnce",get_runOnlyOnce,set_runOnlyOnce,true);
		addMember(l,"relativeSize",get_relativeSize,set_relativeSize,true);
		addMember(l,"initialSize",get_initialSize,set_initialSize,true);
		addMember(l,"borderPadding",get_borderPadding,set_borderPadding,true);
		createTypeMetatable(l,constructor, typeof(UIStretch),typeof(UnityEngine.MonoBehaviour));
	}
}
