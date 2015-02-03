using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_TweenWidth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		TweenWidth o;
		o=new TweenWidth();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetStartToCurrentValue(IntPtr l) {
		try{
			TweenWidth self=(TweenWidth)checkSelf(l);
			self.SetStartToCurrentValue();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEndToCurrentValue(IntPtr l) {
		try{
			TweenWidth self=(TweenWidth)checkSelf(l);
			self.SetEndToCurrentValue();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin_s(IntPtr l) {
		try{
			UIWidget a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			TweenWidth ret=TweenWidth.Begin(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_from(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		pushValue(l,o.from);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_from(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.from=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_to(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		pushValue(l,o.to);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_to(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.to=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateTable(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		pushValue(l,o.updateTable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateTable(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.updateTable=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedWidget(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		pushValue(l,o.cachedWidget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		TweenWidth o = (TweenWidth)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"TweenWidth");
		addMember(l,SetStartToCurrentValue);
		addMember(l,SetEndToCurrentValue);
		addMember(l,Begin_s);
		addMember(l,"from",get_from,set_from,true);
		addMember(l,"to",get_to,set_to,true);
		addMember(l,"updateTable",get_updateTable,set_updateTable,true);
		addMember(l,"cachedWidget",get_cachedWidget,null,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(TweenWidth),typeof(UITweener));
	}
}
