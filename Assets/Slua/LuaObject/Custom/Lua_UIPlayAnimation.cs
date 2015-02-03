using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPlayAnimation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIPlayAnimation o;
		o=new UIPlayAnimation();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Play(a1);
				return 0;
			}
			else if(argc==2){
				UIPlayAnimation self=(UIPlayAnimation)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Play(a1,a2);
				return 0;
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
		pushValue(l,UIPlayAnimation.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UIPlayAnimation v;
		checkType(l,2,out v);
		UIPlayAnimation.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		UnityEngine.Animation v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animator(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushValue(l,o.animator);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animator(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		UnityEngine.Animator v;
		checkType(l,2,out v);
		o.animator=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clipName(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushValue(l,o.clipName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clipName(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.clipName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trigger(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushEnum(l,(int)o.trigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trigger(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		AnimationOrTween.Trigger v;
		checkEnum(l,2,out v);
		o.trigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playDirection(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushEnum(l,(int)o.playDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playDirection(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		AnimationOrTween.Direction v;
		checkEnum(l,2,out v);
		o.playDirection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resetOnPlay(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushValue(l,o.resetOnPlay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resetOnPlay(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.resetOnPlay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clearSelection(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushValue(l,o.clearSelection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clearSelection(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.clearSelection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ifDisabledOnPlay(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushEnum(l,(int)o.ifDisabledOnPlay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ifDisabledOnPlay(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		AnimationOrTween.EnableCondition v;
		checkEnum(l,2,out v);
		o.ifDisabledOnPlay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disableWhenFinished(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushEnum(l,(int)o.disableWhenFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disableWhenFinished(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		AnimationOrTween.DisableCondition v;
		checkEnum(l,2,out v);
		o.disableWhenFinished=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFinished(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		pushValue(l,o.onFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		UIPlayAnimation o = (UIPlayAnimation)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onFinished=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIPlayAnimation");
		addMember(l,Play);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"animator",get_animator,set_animator,true);
		addMember(l,"clipName",get_clipName,set_clipName,true);
		addMember(l,"trigger",get_trigger,set_trigger,true);
		addMember(l,"playDirection",get_playDirection,set_playDirection,true);
		addMember(l,"resetOnPlay",get_resetOnPlay,set_resetOnPlay,true);
		addMember(l,"clearSelection",get_clearSelection,set_clearSelection,true);
		addMember(l,"ifDisabledOnPlay",get_ifDisabledOnPlay,set_ifDisabledOnPlay,true);
		addMember(l,"disableWhenFinished",get_disableWhenFinished,set_disableWhenFinished,true);
		addMember(l,"onFinished",get_onFinished,set_onFinished,true);
		createTypeMetatable(l,constructor, typeof(UIPlayAnimation),typeof(UnityEngine.MonoBehaviour));
	}
}
