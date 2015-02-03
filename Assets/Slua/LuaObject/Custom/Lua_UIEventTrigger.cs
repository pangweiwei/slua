using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIEventTrigger : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIEventTrigger o;
		o=new UIEventTrigger();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UIEventTrigger.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UIEventTrigger v;
		checkType(l,2,out v);
		UIEventTrigger.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onHoverOver(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onHoverOver);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHoverOver(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onHoverOver=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onHoverOut(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onHoverOut);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHoverOut(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onHoverOut=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onPress(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onPress(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onPress=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onRelease(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onRelease);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onRelease(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onRelease=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onSelect(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onSelect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onSelect(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onSelect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDeselect(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onDeselect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDeselect(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onDeselect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDoubleClick(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onDoubleClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDoubleClick(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onDoubleClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragStart(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onDragStart);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragStart(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onDragStart=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragEnd(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onDragEnd);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragEnd(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onDragEnd=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragOver(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onDragOver);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragOver(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onDragOver=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDragOut(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onDragOut);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDragOut(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onDragOut=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onDrag(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		pushValue(l,o.onDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDrag(IntPtr l) {
		UIEventTrigger o = (UIEventTrigger)checkSelf(l);
		System.Collections.Generic.List<EventDelegate> v;
		checkType(l,2,out v);
		o.onDrag=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIEventTrigger");
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"onHoverOver",get_onHoverOver,set_onHoverOver,true);
		addMember(l,"onHoverOut",get_onHoverOut,set_onHoverOut,true);
		addMember(l,"onPress",get_onPress,set_onPress,true);
		addMember(l,"onRelease",get_onRelease,set_onRelease,true);
		addMember(l,"onSelect",get_onSelect,set_onSelect,true);
		addMember(l,"onDeselect",get_onDeselect,set_onDeselect,true);
		addMember(l,"onClick",get_onClick,set_onClick,true);
		addMember(l,"onDoubleClick",get_onDoubleClick,set_onDoubleClick,true);
		addMember(l,"onDragStart",get_onDragStart,set_onDragStart,true);
		addMember(l,"onDragEnd",get_onDragEnd,set_onDragEnd,true);
		addMember(l,"onDragOver",get_onDragOver,set_onDragOver,true);
		addMember(l,"onDragOut",get_onDragOut,set_onDragOut,true);
		addMember(l,"onDrag",get_onDrag,set_onDrag,true);
		createTypeMetatable(l,constructor, typeof(UIEventTrigger),typeof(UnityEngine.MonoBehaviour));
	}
}
