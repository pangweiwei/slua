using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPlayTween : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIPlayTween o;
		o=new UIPlayTween();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			UIPlayTween self=(UIPlayTween)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Play(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenTarget(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushValue(l,o.tweenTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenTarget(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.tweenTarget=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenGroup(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushValue(l,o.tweenGroup);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenGroup(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.tweenGroup=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trigger(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushEnum(l,(int)o.trigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trigger(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		AnimationOrTween.Trigger v;
		checkEnum(l,2,out v);
		o.trigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playDirection(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushEnum(l,(int)o.playDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playDirection(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		AnimationOrTween.Direction v;
		checkEnum(l,2,out v);
		o.playDirection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resetOnPlay(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushValue(l,o.resetOnPlay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resetOnPlay(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.resetOnPlay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resetIfDisabled(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushValue(l,o.resetIfDisabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resetIfDisabled(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.resetIfDisabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ifDisabledOnPlay(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushEnum(l,(int)o.ifDisabledOnPlay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ifDisabledOnPlay(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		AnimationOrTween.EnableCondition v;
		checkEnum(l,2,out v);
		o.ifDisabledOnPlay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disableWhenFinished(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushEnum(l,(int)o.disableWhenFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disableWhenFinished(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		AnimationOrTween.DisableCondition v;
		checkEnum(l,2,out v);
		o.disableWhenFinished=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_includeChildren(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushValue(l,o.includeChildren);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_includeChildren(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.includeChildren=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFinished(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		pushValue(l,o.onFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		UIPlayTween o = (UIPlayTween)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onFinished=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIPlayTween");
		addMember(l,Play);
		addMember(l,"tweenTarget",get_tweenTarget,set_tweenTarget,true);
		addMember(l,"tweenGroup",get_tweenGroup,set_tweenGroup,true);
		addMember(l,"trigger",get_trigger,set_trigger,true);
		addMember(l,"playDirection",get_playDirection,set_playDirection,true);
		addMember(l,"resetOnPlay",get_resetOnPlay,set_resetOnPlay,true);
		addMember(l,"resetIfDisabled",get_resetIfDisabled,set_resetIfDisabled,true);
		addMember(l,"ifDisabledOnPlay",get_ifDisabledOnPlay,set_ifDisabledOnPlay,true);
		addMember(l,"disableWhenFinished",get_disableWhenFinished,set_disableWhenFinished,true);
		addMember(l,"includeChildren",get_includeChildren,set_includeChildren,true);
		addMember(l,"onFinished",get_onFinished,set_onFinished,true);
		createTypeMetatable(l,constructor, typeof(UIPlayTween),typeof(UnityEngine.MonoBehaviour));
	}
}
