using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_TypewriterEffect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		TypewriterEffect o;
		o=new TypewriterEffect();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetToBeginning(IntPtr l) {
		try{
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			self.ResetToBeginning();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Finish(IntPtr l) {
		try{
			TypewriterEffect self=(TypewriterEffect)checkSelf(l);
			self.Finish();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,TypewriterEffect.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		TypewriterEffect v;
		checkType(l,2,out v);
		TypewriterEffect.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_charsPerSecond(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.charsPerSecond);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_charsPerSecond(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.charsPerSecond=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fadeInTime(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.fadeInTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fadeInTime(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.fadeInTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delayOnPeriod(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.delayOnPeriod);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delayOnPeriod(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.delayOnPeriod=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delayOnNewLine(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.delayOnNewLine);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delayOnNewLine(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.delayOnNewLine=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollView(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.scrollView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollView(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		UIScrollView v;
		checkType(l,2,out v);
		o.scrollView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keepFullDimensions(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.keepFullDimensions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keepFullDimensions(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.keepFullDimensions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onFinished(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.onFinished);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onFinished(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onFinished=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isActive(IntPtr l) {
		TypewriterEffect o = (TypewriterEffect)checkSelf(l);
		pushValue(l,o.isActive);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"TypewriterEffect");
		addMember(l,ResetToBeginning);
		addMember(l,Finish);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"charsPerSecond",get_charsPerSecond,set_charsPerSecond,true);
		addMember(l,"fadeInTime",get_fadeInTime,set_fadeInTime,true);
		addMember(l,"delayOnPeriod",get_delayOnPeriod,set_delayOnPeriod,true);
		addMember(l,"delayOnNewLine",get_delayOnNewLine,set_delayOnNewLine,true);
		addMember(l,"scrollView",get_scrollView,set_scrollView,true);
		addMember(l,"keepFullDimensions",get_keepFullDimensions,set_keepFullDimensions,true);
		addMember(l,"onFinished",get_onFinished,set_onFinished,true);
		addMember(l,"isActive",get_isActive,null,true);
		createTypeMetatable(l,constructor, typeof(TypewriterEffect),typeof(UnityEngine.MonoBehaviour));
	}
}
