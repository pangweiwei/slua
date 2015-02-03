using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonKeys : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIButtonKeys o;
		o=new UIButtonKeys();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startsSelected(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		pushValue(l,o.startsSelected);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startsSelected(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.startsSelected=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnClick(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		pushValue(l,o.selectOnClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnClick(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		UIButtonKeys v;
		checkType(l,2,out v);
		o.selectOnClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnUp(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		pushValue(l,o.selectOnUp);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnUp(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		UIButtonKeys v;
		checkType(l,2,out v);
		o.selectOnUp=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnDown(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		pushValue(l,o.selectOnDown);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnDown(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		UIButtonKeys v;
		checkType(l,2,out v);
		o.selectOnDown=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnLeft(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		pushValue(l,o.selectOnLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnLeft(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		UIButtonKeys v;
		checkType(l,2,out v);
		o.selectOnLeft=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnRight(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		pushValue(l,o.selectOnRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnRight(IntPtr l) {
		UIButtonKeys o = (UIButtonKeys)checkSelf(l);
		UIButtonKeys v;
		checkType(l,2,out v);
		o.selectOnRight=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButtonKeys");
		addMember(l,"startsSelected",get_startsSelected,set_startsSelected,true);
		addMember(l,"selectOnClick",get_selectOnClick,set_selectOnClick,true);
		addMember(l,"selectOnUp",get_selectOnUp,set_selectOnUp,true);
		addMember(l,"selectOnDown",get_selectOnDown,set_selectOnDown,true);
		addMember(l,"selectOnLeft",get_selectOnLeft,set_selectOnLeft,true);
		addMember(l,"selectOnRight",get_selectOnRight,set_selectOnRight,true);
		createTypeMetatable(l,constructor, typeof(UIButtonKeys),typeof(UnityEngine.MonoBehaviour));
	}
}
