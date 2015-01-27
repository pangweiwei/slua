using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Navigation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		pushValue(l,o.mode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		UnityEngine.UI.Navigation.Mode v;
		checkEnum(l,2,out v);
		o.mode=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnUp(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		pushValue(l,o.selectOnUp);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnUp(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		UnityEngine.UI.Selectable v;
		checkType(l,2,out v);
		o.selectOnUp=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnDown(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		pushValue(l,o.selectOnDown);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnDown(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		UnityEngine.UI.Selectable v;
		checkType(l,2,out v);
		o.selectOnDown=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnLeft(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		pushValue(l,o.selectOnLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnLeft(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		UnityEngine.UI.Selectable v;
		checkType(l,2,out v);
		o.selectOnLeft=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectOnRight(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
		pushValue(l,o.selectOnRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectOnRight(IntPtr l) {
		UnityEngine.UI.Navigation o = (UnityEngine.UI.Navigation)checkSelf(l);
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
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"selectOnUp",get_selectOnUp,set_selectOnUp,true);
		addMember(l,"selectOnDown",get_selectOnDown,set_selectOnDown,true);
		addMember(l,"selectOnLeft",get_selectOnLeft,set_selectOnLeft,true);
		addMember(l,"selectOnRight",get_selectOnRight,set_selectOnRight,true);
		addMember(l,"defaultNavigation",get_defaultNavigation,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Navigation));
	}
}
