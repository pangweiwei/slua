using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITooltip : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UITooltip o;
		o=new UITooltip();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShowText_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UITooltip.ShowText(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		pushValue(l,o.uiCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiCamera(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.uiCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		UILabel v;
		checkType(l,2,out v);
		o.text=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_background(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		pushValue(l,o.background);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_background(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		UISprite v;
		checkType(l,2,out v);
		o.background=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_appearSpeed(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		pushValue(l,o.appearSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_appearSpeed(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.appearSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scalingTransitions(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		pushValue(l,o.scalingTransitions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scalingTransitions(IntPtr l) {
		UITooltip o = (UITooltip)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.scalingTransitions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isVisible(IntPtr l) {
		pushValue(l,UITooltip.isVisible);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UITooltip");
		addMember(l,ShowText_s);
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"background",get_background,set_background,true);
		addMember(l,"appearSpeed",get_appearSpeed,set_appearSpeed,true);
		addMember(l,"scalingTransitions",get_scalingTransitions,set_scalingTransitions,true);
		addMember(l,"isVisible",get_isVisible,null,false);
		createTypeMetatable(l,constructor, typeof(UITooltip),typeof(UnityEngine.MonoBehaviour));
	}
}
