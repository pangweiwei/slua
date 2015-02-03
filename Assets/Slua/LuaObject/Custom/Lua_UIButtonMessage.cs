using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonMessage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIButtonMessage o;
		o=new UIButtonMessage();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_functionName(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		pushValue(l,o.functionName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_functionName(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.functionName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trigger(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		pushEnum(l,(int)o.trigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trigger(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		UIButtonMessage.Trigger v;
		checkEnum(l,2,out v);
		o.trigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_includeChildren(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		pushValue(l,o.includeChildren);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_includeChildren(IntPtr l) {
		UIButtonMessage o = (UIButtonMessage)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.includeChildren=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButtonMessage");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"functionName",get_functionName,set_functionName,true);
		addMember(l,"trigger",get_trigger,set_trigger,true);
		addMember(l,"includeChildren",get_includeChildren,set_includeChildren,true);
		createTypeMetatable(l,constructor, typeof(UIButtonMessage),typeof(UnityEngine.MonoBehaviour));
	}
}
