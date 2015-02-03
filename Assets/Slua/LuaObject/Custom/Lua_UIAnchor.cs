using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIAnchor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIAnchor o;
		o=new UIAnchor();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		pushValue(l,o.uiCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiCamera(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.uiCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_container(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		pushValue(l,o.container);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_container(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.container=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_side(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		pushEnum(l,(int)o.side);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_side(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		UIAnchor.Side v;
		checkEnum(l,2,out v);
		o.side=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runOnlyOnce(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		pushValue(l,o.runOnlyOnce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runOnlyOnce(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.runOnlyOnce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeOffset(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		pushValue(l,o.relativeOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relativeOffset(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.relativeOffset=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelOffset(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		pushValue(l,o.pixelOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelOffset(IntPtr l) {
		UIAnchor o = (UIAnchor)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pixelOffset=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIAnchor");
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"container",get_container,set_container,true);
		addMember(l,"side",get_side,set_side,true);
		addMember(l,"runOnlyOnce",get_runOnlyOnce,set_runOnlyOnce,true);
		addMember(l,"relativeOffset",get_relativeOffset,set_relativeOffset,true);
		addMember(l,"pixelOffset",get_pixelOffset,set_pixelOffset,true);
		createTypeMetatable(l,constructor, typeof(UIAnchor),typeof(UnityEngine.MonoBehaviour));
	}
}
