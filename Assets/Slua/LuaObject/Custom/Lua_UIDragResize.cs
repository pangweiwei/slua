using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragResize : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDragResize o;
		o=new UIDragResize();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		UIWidget v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		pushEnum(l,(int)o.pivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		UIWidget.Pivot v;
		checkEnum(l,2,out v);
		o.pivot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minWidth(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.minWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minHeight(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.minHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxWidth(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		pushValue(l,o.maxWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxWidth(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxHeight(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		pushValue(l,o.maxHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxHeight(IntPtr l) {
		UIDragResize o = (UIDragResize)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxHeight=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragResize");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"minWidth",get_minWidth,set_minWidth,true);
		addMember(l,"minHeight",get_minHeight,set_minHeight,true);
		addMember(l,"maxWidth",get_maxWidth,set_maxWidth,true);
		addMember(l,"maxHeight",get_maxHeight,set_maxHeight,true);
		createTypeMetatable(l,constructor, typeof(UIDragResize),typeof(UnityEngine.MonoBehaviour));
	}
}
