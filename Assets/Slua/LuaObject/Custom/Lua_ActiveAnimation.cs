using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ActiveAnimation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		ActiveAnimation o;
		o=new ActiveAnimation();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Finish(IntPtr l) {
		try{
			ActiveAnimation self=(ActiveAnimation)checkSelf(l);
			self.Finish();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try{
			ActiveAnimation self=(ActiveAnimation)checkSelf(l);
			self.Reset();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Animation),typeof(string),typeof(AnimationOrTween.Direction),typeof(AnimationOrTween.EnableCondition),typeof(AnimationOrTween.DisableCondition))){
				UnityEngine.Animation a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				AnimationOrTween.Direction a3;
				checkEnum(l,3,out a3);
				AnimationOrTween.EnableCondition a4;
				checkEnum(l,4,out a4);
				AnimationOrTween.DisableCondition a5;
				checkEnum(l,5,out a5);
				ActiveAnimation ret=ActiveAnimation.Play(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Animation a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				AnimationOrTween.Direction a3;
				checkEnum(l,3,out a3);
				ActiveAnimation ret=ActiveAnimation.Play(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Animation a1;
				checkType(l,1,out a1);
				AnimationOrTween.Direction a2;
				checkEnum(l,2,out a2);
				ActiveAnimation ret=ActiveAnimation.Play(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Animator),typeof(string),typeof(AnimationOrTween.Direction),typeof(AnimationOrTween.EnableCondition),typeof(AnimationOrTween.DisableCondition))){
				UnityEngine.Animator a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				AnimationOrTween.Direction a3;
				checkEnum(l,3,out a3);
				AnimationOrTween.EnableCondition a4;
				checkEnum(l,4,out a4);
				AnimationOrTween.DisableCondition a5;
				checkEnum(l,5,out a5);
				ActiveAnimation ret=ActiveAnimation.Play(a1,a2,a3,a4,a5);
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
	static public int get_current(IntPtr l) {
		pushValue(l,ActiveAnimation.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		ActiveAnimation v;
		checkType(l,2,out v);
		ActiveAnimation.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFinished(IntPtr l) {
		ActiveAnimation o = (ActiveAnimation)checkSelf(l);
		pushValue(l,o.onFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		ActiveAnimation o = (ActiveAnimation)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onFinished=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventReceiver(IntPtr l) {
		ActiveAnimation o = (ActiveAnimation)checkSelf(l);
		pushValue(l,o.eventReceiver);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventReceiver(IntPtr l) {
		ActiveAnimation o = (ActiveAnimation)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.eventReceiver=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_callWhenFinished(IntPtr l) {
		ActiveAnimation o = (ActiveAnimation)checkSelf(l);
		pushValue(l,o.callWhenFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_callWhenFinished(IntPtr l) {
		ActiveAnimation o = (ActiveAnimation)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.callWhenFinished=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		ActiveAnimation o = (ActiveAnimation)checkSelf(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ActiveAnimation");
		addMember(l,Finish);
		addMember(l,Reset);
		addMember(l,Play_s);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"onFinished",get_onFinished,set_onFinished,true);
		addMember(l,"eventReceiver",get_eventReceiver,set_eventReceiver,true);
		addMember(l,"callWhenFinished",get_callWhenFinished,set_callWhenFinished,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		createTypeMetatable(l,constructor, typeof(ActiveAnimation),typeof(UnityEngine.MonoBehaviour));
	}
}
