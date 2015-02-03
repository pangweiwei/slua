using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_TweenTransform : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		TweenTransform o;
		o=new TweenTransform();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Transform a3;
				checkType(l,3,out a3);
				TweenTransform ret=TweenTransform.Begin(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Transform a3;
				checkType(l,3,out a3);
				UnityEngine.Transform a4;
				checkType(l,4,out a4);
				TweenTransform ret=TweenTransform.Begin(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_from(IntPtr l) {
		TweenTransform o = (TweenTransform)checkSelf(l);
		pushValue(l,o.from);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_from(IntPtr l) {
		TweenTransform o = (TweenTransform)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.from=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_to(IntPtr l) {
		TweenTransform o = (TweenTransform)checkSelf(l);
		pushValue(l,o.to);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_to(IntPtr l) {
		TweenTransform o = (TweenTransform)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.to=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_parentWhenFinished(IntPtr l) {
		TweenTransform o = (TweenTransform)checkSelf(l);
		pushValue(l,o.parentWhenFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_parentWhenFinished(IntPtr l) {
		TweenTransform o = (TweenTransform)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.parentWhenFinished=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"TweenTransform");
		addMember(l,Begin_s);
		addMember(l,"from",get_from,set_from,true);
		addMember(l,"to",get_to,set_to,true);
		addMember(l,"parentWhenFinished",get_parentWhenFinished,set_parentWhenFinished,true);
		createTypeMetatable(l,constructor, typeof(TweenTransform),typeof(UITweener));
	}
}
