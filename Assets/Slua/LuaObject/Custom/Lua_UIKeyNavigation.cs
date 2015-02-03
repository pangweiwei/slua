using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIKeyNavigation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIKeyNavigation o;
		o=new UIKeyNavigation();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_list(IntPtr l) {
		pushValue(l,UIKeyNavigation.list);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_list(IntPtr l) {
		BetterList<UIKeyNavigation> v;
		checkType(l,2,out v);
		UIKeyNavigation.list=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraint(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		pushEnum(l,(int)o.constraint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraint(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		UIKeyNavigation.Constraint v;
		checkEnum(l,2,out v);
		o.constraint=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onUp(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		pushValue(l,o.onUp);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUp(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.onUp=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDown(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		pushValue(l,o.onDown);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDown(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.onDown=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onLeft(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		pushValue(l,o.onLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onLeft(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.onLeft=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onRight(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		pushValue(l,o.onRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onRight(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.onRight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		pushValue(l,o.onClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.onClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startsSelected(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		pushValue(l,o.startsSelected);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startsSelected(IntPtr l) {
		UIKeyNavigation o = (UIKeyNavigation)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.startsSelected=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIKeyNavigation");
		addMember(l,"list",get_list,set_list,false);
		addMember(l,"constraint",get_constraint,set_constraint,true);
		addMember(l,"onUp",get_onUp,set_onUp,true);
		addMember(l,"onDown",get_onDown,set_onDown,true);
		addMember(l,"onLeft",get_onLeft,set_onLeft,true);
		addMember(l,"onRight",get_onRight,set_onRight,true);
		addMember(l,"onClick",get_onClick,set_onClick,true);
		addMember(l,"startsSelected",get_startsSelected,set_startsSelected,true);
		createTypeMetatable(l,constructor, typeof(UIKeyNavigation),typeof(UnityEngine.MonoBehaviour));
	}
}
