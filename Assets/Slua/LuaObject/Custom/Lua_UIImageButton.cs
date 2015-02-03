using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIImageButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIImageButton o;
		o=new UIImageButton();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		UISprite v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		pushValue(l,o.normalSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.normalSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hoverSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		pushValue(l,o.hoverSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hoverSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.hoverSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		pushValue(l,o.pressedSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.pressedSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		pushValue(l,o.disabledSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledSprite(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.disabledSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSnap(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		pushValue(l,o.pixelSnap);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelSnap(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.pixelSnap=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEnabled(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		pushValue(l,o.isEnabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isEnabled(IntPtr l) {
		UIImageButton o = (UIImageButton)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isEnabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIImageButton");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"normalSprite",get_normalSprite,set_normalSprite,true);
		addMember(l,"hoverSprite",get_hoverSprite,set_hoverSprite,true);
		addMember(l,"pressedSprite",get_pressedSprite,set_pressedSprite,true);
		addMember(l,"disabledSprite",get_disabledSprite,set_disabledSprite,true);
		addMember(l,"pixelSnap",get_pixelSnap,set_pixelSnap,true);
		addMember(l,"isEnabled",get_isEnabled,set_isEnabled,true);
		createTypeMetatable(l,constructor, typeof(UIImageButton),typeof(UnityEngine.MonoBehaviour));
	}
}
