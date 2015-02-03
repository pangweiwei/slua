using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_TweenVolume : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		TweenVolume o;
		o=new TweenVolume();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetStartToCurrentValue(IntPtr l) {
		try{
			TweenVolume self=(TweenVolume)checkSelf(l);
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
			TweenVolume self=(TweenVolume)checkSelf(l);
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
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			TweenVolume ret=TweenVolume.Begin(a1,a2,a3);
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
		TweenVolume o = (TweenVolume)checkSelf(l);
		pushValue(l,o.from);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_from(IntPtr l) {
		TweenVolume o = (TweenVolume)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.from=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_to(IntPtr l) {
		TweenVolume o = (TweenVolume)checkSelf(l);
		pushValue(l,o.to);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_to(IntPtr l) {
		TweenVolume o = (TweenVolume)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.to=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audioSource(IntPtr l) {
		TweenVolume o = (TweenVolume)checkSelf(l);
		pushValue(l,o.audioSource);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		TweenVolume o = (TweenVolume)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		TweenVolume o = (TweenVolume)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"TweenVolume");
		addMember(l,SetStartToCurrentValue);
		addMember(l,SetEndToCurrentValue);
		addMember(l,Begin_s);
		addMember(l,"from",get_from,set_from,true);
		addMember(l,"to",get_to,set_to,true);
		addMember(l,"audioSource",get_audioSource,null,true);
		addMember(l,"value",get_value,set_value,true);
		createTypeMetatable(l,constructor, typeof(TweenVolume),typeof(UITweener));
	}
}
