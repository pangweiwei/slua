using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UILocalize : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UILocalize o;
		o=new UILocalize();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_key(IntPtr l) {
		UILocalize o = (UILocalize)checkSelf(l);
		pushValue(l,o.key);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_key(IntPtr l) {
		UILocalize o = (UILocalize)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.key=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UILocalize o = (UILocalize)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UILocalize");
		addMember(l,"key",get_key,set_key,true);
		addMember(l,"value",null,set_value,true);
		createTypeMetatable(l,constructor, typeof(UILocalize),typeof(UnityEngine.MonoBehaviour));
	}
}
