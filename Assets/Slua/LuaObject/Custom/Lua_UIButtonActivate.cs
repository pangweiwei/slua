using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonActivate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIButtonActivate o;
		o=new UIButtonActivate();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIButtonActivate o = (UIButtonActivate)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIButtonActivate o = (UIButtonActivate)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_state(IntPtr l) {
		UIButtonActivate o = (UIButtonActivate)checkSelf(l);
		pushValue(l,o.state);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_state(IntPtr l) {
		UIButtonActivate o = (UIButtonActivate)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.state=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButtonActivate");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"state",get_state,set_state,true);
		createTypeMetatable(l,constructor, typeof(UIButtonActivate),typeof(UnityEngine.MonoBehaviour));
	}
}
