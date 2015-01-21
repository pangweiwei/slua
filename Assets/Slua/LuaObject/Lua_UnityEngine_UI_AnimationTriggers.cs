using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_AnimationTriggers : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.UI.AnimationTriggers o;
		if(matchType(l,1)){
			o=new UnityEngine.UI.AnimationTriggers();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,o.normalTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.normalTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,o.highlightedTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.highlightedTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,o.pressedTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.pressedTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		pushValue(l,o.disabledTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledTrigger(IntPtr l) {
		UnityEngine.UI.AnimationTriggers o = (UnityEngine.UI.AnimationTriggers)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.disabledTrigger=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.AnimationTriggers");
		addMember(l,"normalTrigger",get_normalTrigger,set_normalTrigger);
		addMember(l,"highlightedTrigger",get_highlightedTrigger,set_highlightedTrigger);
		addMember(l,"pressedTrigger",get_pressedTrigger,set_pressedTrigger);
		addMember(l,"disabledTrigger",get_disabledTrigger,set_disabledTrigger);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.AnimationTriggers));
	}
}
