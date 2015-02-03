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
	static public int SaveSelection(IntPtr l) {
		try{
			UISavedOption self=(UISavedOption)checkSelf(l);
			self.SaveSelection();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SaveState(IntPtr l) {
		try{
			UISavedOption self=(UISavedOption)checkSelf(l);
			self.SaveState();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SaveProgress(IntPtr l) {
		try{
			UISavedOption self=(UISavedOption)checkSelf(l);
			self.SaveProgress();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
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
		addMember(l,SaveSelection);
		addMember(l,SaveState);
		addMember(l,SaveProgress);
		addMember(l,"keyName",get_keyName,set_keyName,true);
		createTypeMetatable(l,constructor, typeof(UISavedOption),typeof(UnityEngine.MonoBehaviour));
	}
}
