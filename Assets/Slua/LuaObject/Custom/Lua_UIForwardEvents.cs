using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIForwardEvents : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIForwardEvents o;
		o=new UIForwardEvents();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onHover(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onHover);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHover(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onHover=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onPress(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onPress(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onPress=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDoubleClick(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onDoubleClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDoubleClick(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onDoubleClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSelect(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onSelect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSelect(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onSelect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDrag(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrag(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onDrag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDrop(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onDrop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrop(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onDrop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSubmit(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onSubmit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSubmit(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onSubmit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onScroll(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		pushValue(l,o.onScroll);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onScroll(IntPtr l) {
		UIForwardEvents o = (UIForwardEvents)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.onScroll=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIForwardEvents");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"onHover",get_onHover,set_onHover,true);
		addMember(l,"onPress",get_onPress,set_onPress,true);
		addMember(l,"onClick",get_onClick,set_onClick,true);
		addMember(l,"onDoubleClick",get_onDoubleClick,set_onDoubleClick,true);
		addMember(l,"onSelect",get_onSelect,set_onSelect,true);
		addMember(l,"onDrag",get_onDrag,set_onDrag,true);
		addMember(l,"onDrop",get_onDrop,set_onDrop,true);
		addMember(l,"onSubmit",get_onSubmit,set_onSubmit,true);
		addMember(l,"onScroll",get_onScroll,set_onScroll,true);
		createTypeMetatable(l,constructor, typeof(UIForwardEvents),typeof(UnityEngine.MonoBehaviour));
	}
}
