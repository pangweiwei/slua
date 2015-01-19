using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Navigation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		pushValue(l,o.mode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		UnityEngine.UI.Navigation.Mode v;
		checkEnum(l,2,out v);
		o.mode=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnUp(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		pushValue(l,o.selectOnUp);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnUp(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		UnityEngine.UI.Selectable v;
		checkType(l,2,out v);
		o.selectOnUp=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnDown(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		pushValue(l,o.selectOnDown);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnDown(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		UnityEngine.UI.Selectable v;
		checkType(l,2,out v);
		o.selectOnDown=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnLeft(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		pushValue(l,o.selectOnLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnLeft(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		UnityEngine.UI.Selectable v;
		checkType(l,2,out v);
		o.selectOnLeft=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnRight(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		pushValue(l,o.selectOnRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnRight(IntPtr l) {
		UnityEngine.UI.Navigation o = checkSelf<UnityEngine.UI.Navigation>(l);
		UnityEngine.UI.Selectable v;
		checkType(l,2,out v);
		o.selectOnRight=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultNavigation(IntPtr l) {
		pushValue(l,UnityEngine.UI.Navigation.defaultNavigation);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Navigation");
		addMember(l,get_mode, "get_mode");
		addMember(l,set_mode, "set_mode");
		addMember(l,get_selectOnUp, "get_selectOnUp");
		addMember(l,set_selectOnUp, "set_selectOnUp");
		addMember(l,get_selectOnDown, "get_selectOnDown");
		addMember(l,set_selectOnDown, "set_selectOnDown");
		addMember(l,get_selectOnLeft, "get_selectOnLeft");
		addMember(l,set_selectOnLeft, "set_selectOnLeft");
		addMember(l,get_selectOnRight, "get_selectOnRight");
		addMember(l,set_selectOnRight, "set_selectOnRight");
		addMember(l,get_defaultNavigation, "get_defaultNavigation");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Navigation));
		LuaDLL.lua_pop(l, 1);
	}
}
