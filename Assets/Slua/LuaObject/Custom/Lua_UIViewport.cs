using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIViewport : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIViewport o;
		o=new UIViewport();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sourceCamera(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		pushValue(l,o.sourceCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sourceCamera(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.sourceCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_topLeft(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		pushValue(l,o.topLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_topLeft(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.topLeft=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bottomRight(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		pushValue(l,o.bottomRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bottomRight(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.bottomRight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fullSize(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		pushValue(l,o.fullSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fullSize(IntPtr l) {
		UIViewport o = (UIViewport)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.fullSize=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIViewport");
		addMember(l,"sourceCamera",get_sourceCamera,set_sourceCamera,true);
		addMember(l,"topLeft",get_topLeft,set_topLeft,true);
		addMember(l,"bottomRight",get_bottomRight,set_bottomRight,true);
		addMember(l,"fullSize",get_fullSize,set_fullSize,true);
		createTypeMetatable(l,constructor, typeof(UIViewport),typeof(UnityEngine.MonoBehaviour));
	}
}
