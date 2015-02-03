using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICamera_MouseOrTouch : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UICamera.MouseOrTouch o;
		o=new UICamera.MouseOrTouch();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pos(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.pos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pos(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pos=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastPos(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.lastPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lastPos(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.lastPos=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delta(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.delta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delta(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.delta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_totalDelta(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.totalDelta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_totalDelta(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.totalDelta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedCam(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.pressedCam);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedCam(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.pressedCam=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_last(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.last);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_last(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.last=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressed(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.pressed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressed(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.pressed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragged(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.dragged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragged(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.dragged=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickTime(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.clickTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickTime(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.clickTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickNotification(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushEnum(l,(int)o.clickNotification);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickNotification(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		UICamera.ClickNotification v;
		checkEnum(l,2,out v);
		o.clickNotification=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchBegan(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.touchBegan);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchBegan(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.touchBegan=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressStarted(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.pressStarted);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressStarted(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.pressStarted=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragStarted(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		pushValue(l,o.dragStarted);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragStarted(IntPtr l) {
		UICamera.MouseOrTouch o = (UICamera.MouseOrTouch)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.dragStarted=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UICamera.MouseOrTouch");
		addMember(l,"pos",get_pos,set_pos,true);
		addMember(l,"lastPos",get_lastPos,set_lastPos,true);
		addMember(l,"delta",get_delta,set_delta,true);
		addMember(l,"totalDelta",get_totalDelta,set_totalDelta,true);
		addMember(l,"pressedCam",get_pressedCam,set_pressedCam,true);
		addMember(l,"last",get_last,set_last,true);
		addMember(l,"current",get_current,set_current,true);
		addMember(l,"pressed",get_pressed,set_pressed,true);
		addMember(l,"dragged",get_dragged,set_dragged,true);
		addMember(l,"clickTime",get_clickTime,set_clickTime,true);
		addMember(l,"clickNotification",get_clickNotification,set_clickNotification,true);
		addMember(l,"touchBegan",get_touchBegan,set_touchBegan,true);
		addMember(l,"pressStarted",get_pressStarted,set_pressStarted,true);
		addMember(l,"dragStarted",get_dragStarted,set_dragStarted,true);
		createTypeMetatable(l,constructor, typeof(UICamera.MouseOrTouch));
	}
}
