using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISavedOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UISavedOption o;
		o=new UISavedOption();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyName(IntPtr l) {
		UISavedOption o = (UISavedOption)checkSelf(l);
		pushValue(l,o.keyName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyName(IntPtr l) {
		UISavedOption o = (UISavedOption)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.keyName=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISavedOption");
		addMember(l,"keyName",get_keyName,set_keyName,true);
		createTypeMetatable(l,constructor, typeof(UISavedOption),typeof(UnityEngine.MonoBehaviour));
	}
}
