using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButton : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIButton o;
		o=new UIButton();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UIButton.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UIButton v;
		checkType(l,2,out v);
		UIButton.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragHighlight(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.dragHighlight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragHighlight(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.dragHighlight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hoverSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.hoverSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hoverSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.hoverSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.pressedSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.pressedSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.disabledSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.disabledSprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelSnap(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.pixelSnap);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelSnap(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.pixelSnap=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.onClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEnabled(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.isEnabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isEnabled(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isEnabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		pushValue(l,o.normalSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalSprite(IntPtr l) {
		UIButton o = (UIButton)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.normalSprite=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButton");
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"dragHighlight",get_dragHighlight,set_dragHighlight,true);
		addMember(l,"hoverSprite",get_hoverSprite,set_hoverSprite,true);
		addMember(l,"pressedSprite",get_pressedSprite,set_pressedSprite,true);
		addMember(l,"disabledSprite",get_disabledSprite,set_disabledSprite,true);
		addMember(l,"pixelSnap",get_pixelSnap,set_pixelSnap,true);
		addMember(l,"onClick",get_onClick,set_onClick,true);
		addMember(l,"isEnabled",get_isEnabled,set_isEnabled,true);
		addMember(l,"normalSprite",get_normalSprite,set_normalSprite,true);
		createTypeMetatable(l,constructor, typeof(UIButton),typeof(UIButtonColor));
	}
}
