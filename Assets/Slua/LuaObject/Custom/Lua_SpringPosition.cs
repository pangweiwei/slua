using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_SpringPosition : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		SpringPosition o;
		o=new SpringPosition();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Begin_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			SpringPosition ret=SpringPosition.Begin(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,SpringPosition.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		SpringPosition v;
		checkType(l,2,out v);
		SpringPosition.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_strength(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		pushValue(l,o.strength);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_strength(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.strength=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldSpace(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		pushValue(l,o.worldSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldSpace(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.worldSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreTimeScale(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		pushValue(l,o.ignoreTimeScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreTimeScale(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreTimeScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateScrollView(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		pushValue(l,o.updateScrollView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateScrollView(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.updateScrollView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		SpringPosition.OnFinished v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onFinished=v;
		else if(op==1) o.onFinished+=v;
		else if(op==2) o.onFinished-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_callWhenFinished(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		pushValue(l,o.callWhenFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_callWhenFinished(IntPtr l) {
		SpringPosition o = (SpringPosition)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.callWhenFinished=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"SpringPosition");
		addMember(l,Begin_s);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"strength",get_strength,set_strength,true);
		addMember(l,"worldSpace",get_worldSpace,set_worldSpace,true);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		addMember(l,"updateScrollView",get_updateScrollView,set_updateScrollView,true);
		addMember(l,"onFinished",null,set_onFinished,true);
		addMember(l,"callWhenFinished",get_callWhenFinished,set_callWhenFinished,true);
		createTypeMetatable(l,constructor, typeof(SpringPosition),typeof(UnityEngine.MonoBehaviour));
	}
}
