using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIKeyBinding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIKeyBinding o;
		o=new UIKeyBinding();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyCode(IntPtr l) {
		UIKeyBinding o = (UIKeyBinding)checkSelf(l);
		pushEnum(l,(int)o.keyCode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyCode(IntPtr l) {
		UIKeyBinding o = (UIKeyBinding)checkSelf(l);
		UnityEngine.KeyCode v;
		checkEnum(l,2,out v);
		o.keyCode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modifier(IntPtr l) {
		UIKeyBinding o = (UIKeyBinding)checkSelf(l);
		pushEnum(l,(int)o.modifier);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modifier(IntPtr l) {
		UIKeyBinding o = (UIKeyBinding)checkSelf(l);
		UIKeyBinding.Modifier v;
		checkEnum(l,2,out v);
		o.modifier=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_action(IntPtr l) {
		UIKeyBinding o = (UIKeyBinding)checkSelf(l);
		pushEnum(l,(int)o.action);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_action(IntPtr l) {
		UIKeyBinding o = (UIKeyBinding)checkSelf(l);
		UIKeyBinding.Action v;
		checkEnum(l,2,out v);
		o.action=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIKeyBinding");
		addMember(l,"keyCode",get_keyCode,set_keyCode,true);
		addMember(l,"modifier",get_modifier,set_modifier,true);
		addMember(l,"action",get_action,set_action,true);
		createTypeMetatable(l,constructor, typeof(UIKeyBinding),typeof(UnityEngine.MonoBehaviour));
	}
}
