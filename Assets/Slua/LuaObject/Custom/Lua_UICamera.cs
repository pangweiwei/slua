using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UICamera o;
		o=new UICamera();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessMouse(IntPtr l) {
		try{
			UICamera self=(UICamera)checkSelf(l);
			self.ProcessMouse();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessTouches(IntPtr l) {
		try{
			UICamera self=(UICamera)checkSelf(l);
			self.ProcessTouches();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessOthers(IntPtr l) {
		try{
			UICamera self=(UICamera)checkSelf(l);
			self.ProcessOthers();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessTouch(IntPtr l) {
		try{
			UICamera self=(UICamera)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.ProcessTouch(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShowTooltip(IntPtr l) {
		try{
			UICamera self=(UICamera)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.ShowTooltip(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast_s(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.RaycastHit a2;
			System.Boolean ret=UICamera.Raycast(a1,out a2);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsHighlighted_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.Boolean ret=UICamera.IsHighlighted(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindCameraForLayer_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UICamera ret=UICamera.FindCameraForLayer(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Notify_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Object a3;
			checkType(l,3,out a3);
			UICamera.Notify(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMouse_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UICamera.MouseOrTouch ret=UICamera.GetMouse(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTouch_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UICamera.MouseOrTouch ret=UICamera.GetTouch(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveTouch_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UICamera.RemoveTouch(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_list(IntPtr l) {
		pushValue(l,UICamera.list);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_list(IntPtr l) {
		BetterList<UICamera> v;
		checkType(l,2,out v);
		UICamera.list=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onScreenResize(IntPtr l) {
		UICamera.OnScreenResize v;
		int op=checkDelegate(l,2,out v);
		if(op==0) UICamera.onScreenResize=v;
		else if(op==1) UICamera.onScreenResize+=v;
		else if(op==2) UICamera.onScreenResize-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventType(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushEnum(l,(int)o.eventType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventType(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		UICamera.EventType v;
		checkEnum(l,2,out v);
		o.eventType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventReceiverMask(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.eventReceiverMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventReceiverMask(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		UnityEngine.LayerMask v;
		checkType(l,2,out v);
		o.eventReceiverMask=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_debug(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.debug);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_debug(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.debug=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMouse(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.useMouse);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMouse(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useMouse=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useTouch(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.useTouch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useTouch(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useTouch=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allowMultiTouch(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.allowMultiTouch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowMultiTouch(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.allowMultiTouch=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useKeyboard(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.useKeyboard);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useKeyboard(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useKeyboard=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useController(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.useController);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useController(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useController=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stickyTooltip(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.stickyTooltip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stickyTooltip(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.stickyTooltip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tooltipDelay(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.tooltipDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tooltipDelay(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.tooltipDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mouseDragThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.mouseDragThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mouseDragThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.mouseDragThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mouseClickThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.mouseClickThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mouseClickThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.mouseClickThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchDragThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.touchDragThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchDragThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.touchDragThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchClickThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.touchClickThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_touchClickThreshold(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.touchClickThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rangeDistance(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.rangeDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rangeDistance(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.rangeDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollAxisName(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.scrollAxisName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollAxisName(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.scrollAxisName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAxisName(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.verticalAxisName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalAxisName(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.verticalAxisName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalAxisName(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.horizontalAxisName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalAxisName(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.horizontalAxisName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_submitKey0(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushEnum(l,(int)o.submitKey0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_submitKey0(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		UnityEngine.KeyCode v;
		checkEnum(l,2,out v);
		o.submitKey0=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_submitKey1(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushEnum(l,(int)o.submitKey1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_submitKey1(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		UnityEngine.KeyCode v;
		checkEnum(l,2,out v);
		o.submitKey1=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cancelKey0(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushEnum(l,(int)o.cancelKey0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cancelKey0(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		UnityEngine.KeyCode v;
		checkEnum(l,2,out v);
		o.cancelKey0=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cancelKey1(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushEnum(l,(int)o.cancelKey1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cancelKey1(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		UnityEngine.KeyCode v;
		checkEnum(l,2,out v);
		o.cancelKey1=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCustomInput(IntPtr l) {
		UICamera.OnCustomInput v;
		int op=checkDelegate(l,2,out v);
		if(op==0) UICamera.onCustomInput=v;
		else if(op==1) UICamera.onCustomInput+=v;
		else if(op==2) UICamera.onCustomInput-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showTooltips(IntPtr l) {
		pushValue(l,UICamera.showTooltips);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showTooltips(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UICamera.showTooltips=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastTouchPosition(IntPtr l) {
		pushValue(l,UICamera.lastTouchPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lastTouchPosition(IntPtr l) {
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		UICamera.lastTouchPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastHit(IntPtr l) {
		pushValue(l,UICamera.lastHit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lastHit(IntPtr l) {
		UnityEngine.RaycastHit v;
		checkType(l,2,out v);
		UICamera.lastHit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UICamera.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UICamera v;
		checkType(l,2,out v);
		UICamera.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentCamera(IntPtr l) {
		pushValue(l,UICamera.currentCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentCamera(IntPtr l) {
		UnityEngine.Camera v;
		checkType(l,2,out v);
		UICamera.currentCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentScheme(IntPtr l) {
		pushEnum(l,(int)UICamera.currentScheme);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentScheme(IntPtr l) {
		UICamera.ControlScheme v;
		checkEnum(l,2,out v);
		UICamera.currentScheme=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentTouchID(IntPtr l) {
		pushValue(l,UICamera.currentTouchID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentTouchID(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UICamera.currentTouchID=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentKey(IntPtr l) {
		pushEnum(l,(int)UICamera.currentKey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentKey(IntPtr l) {
		UnityEngine.KeyCode v;
		checkEnum(l,2,out v);
		UICamera.currentKey=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentTouch(IntPtr l) {
		pushValue(l,UICamera.currentTouch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currentTouch(IntPtr l) {
		UICamera.MouseOrTouch v;
		checkType(l,2,out v);
		UICamera.currentTouch=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputHasFocus(IntPtr l) {
		pushValue(l,UICamera.inputHasFocus);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputHasFocus(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UICamera.inputHasFocus=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_genericEventHandler(IntPtr l) {
		pushValue(l,UICamera.genericEventHandler);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_genericEventHandler(IntPtr l) {
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		UICamera.genericEventHandler=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fallThrough(IntPtr l) {
		pushValue(l,UICamera.fallThrough);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fallThrough(IntPtr l) {
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		UICamera.fallThrough=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_controller(IntPtr l) {
		pushValue(l,UICamera.controller);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_controller(IntPtr l) {
		UICamera.MouseOrTouch v;
		checkType(l,2,out v);
		UICamera.controller=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDragging(IntPtr l) {
		pushValue(l,UICamera.isDragging);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isDragging(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UICamera.isDragging=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hoveredObject(IntPtr l) {
		pushValue(l,UICamera.hoveredObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hoveredObject(IntPtr l) {
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		UICamera.hoveredObject=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentRay(IntPtr l) {
		pushValue(l,UICamera.currentRay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cachedCamera(IntPtr l) {
		UICamera o = (UICamera)checkSelf(l);
		pushValue(l,o.cachedCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedObject(IntPtr l) {
		pushValue(l,UICamera.selectedObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedObject(IntPtr l) {
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		UICamera.selectedObject=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchCount(IntPtr l) {
		pushValue(l,UICamera.touchCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragCount(IntPtr l) {
		pushValue(l,UICamera.dragCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainCamera(IntPtr l) {
		pushValue(l,UICamera.mainCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventHandler(IntPtr l) {
		pushValue(l,UICamera.eventHandler);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UICamera");
		addMember(l,ProcessMouse);
		addMember(l,ProcessTouches);
		addMember(l,ProcessOthers);
		addMember(l,ProcessTouch);
		addMember(l,ShowTooltip);
		addMember(l,Raycast_s);
		addMember(l,IsHighlighted_s);
		addMember(l,FindCameraForLayer_s);
		addMember(l,Notify_s);
		addMember(l,GetMouse_s);
		addMember(l,GetTouch_s);
		addMember(l,RemoveTouch_s);
		addMember(l,"list",get_list,set_list,false);
		addMember(l,"onScreenResize",null,set_onScreenResize,false);
		addMember(l,"eventType",get_eventType,set_eventType,true);
		addMember(l,"eventReceiverMask",get_eventReceiverMask,set_eventReceiverMask,true);
		addMember(l,"debug",get_debug,set_debug,true);
		addMember(l,"useMouse",get_useMouse,set_useMouse,true);
		addMember(l,"useTouch",get_useTouch,set_useTouch,true);
		addMember(l,"allowMultiTouch",get_allowMultiTouch,set_allowMultiTouch,true);
		addMember(l,"useKeyboard",get_useKeyboard,set_useKeyboard,true);
		addMember(l,"useController",get_useController,set_useController,true);
		addMember(l,"stickyTooltip",get_stickyTooltip,set_stickyTooltip,true);
		addMember(l,"tooltipDelay",get_tooltipDelay,set_tooltipDelay,true);
		addMember(l,"mouseDragThreshold",get_mouseDragThreshold,set_mouseDragThreshold,true);
		addMember(l,"mouseClickThreshold",get_mouseClickThreshold,set_mouseClickThreshold,true);
		addMember(l,"touchDragThreshold",get_touchDragThreshold,set_touchDragThreshold,true);
		addMember(l,"touchClickThreshold",get_touchClickThreshold,set_touchClickThreshold,true);
		addMember(l,"rangeDistance",get_rangeDistance,set_rangeDistance,true);
		addMember(l,"scrollAxisName",get_scrollAxisName,set_scrollAxisName,true);
		addMember(l,"verticalAxisName",get_verticalAxisName,set_verticalAxisName,true);
		addMember(l,"horizontalAxisName",get_horizontalAxisName,set_horizontalAxisName,true);
		addMember(l,"submitKey0",get_submitKey0,set_submitKey0,true);
		addMember(l,"submitKey1",get_submitKey1,set_submitKey1,true);
		addMember(l,"cancelKey0",get_cancelKey0,set_cancelKey0,true);
		addMember(l,"cancelKey1",get_cancelKey1,set_cancelKey1,true);
		addMember(l,"onCustomInput",null,set_onCustomInput,false);
		addMember(l,"showTooltips",get_showTooltips,set_showTooltips,false);
		addMember(l,"lastTouchPosition",get_lastTouchPosition,set_lastTouchPosition,false);
		addMember(l,"lastHit",get_lastHit,set_lastHit,false);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"currentCamera",get_currentCamera,set_currentCamera,false);
		addMember(l,"currentScheme",get_currentScheme,set_currentScheme,false);
		addMember(l,"currentTouchID",get_currentTouchID,set_currentTouchID,false);
		addMember(l,"currentKey",get_currentKey,set_currentKey,false);
		addMember(l,"currentTouch",get_currentTouch,set_currentTouch,false);
		addMember(l,"inputHasFocus",get_inputHasFocus,set_inputHasFocus,false);
		addMember(l,"genericEventHandler",get_genericEventHandler,set_genericEventHandler,false);
		addMember(l,"fallThrough",get_fallThrough,set_fallThrough,false);
		addMember(l,"controller",get_controller,set_controller,false);
		addMember(l,"isDragging",get_isDragging,set_isDragging,false);
		addMember(l,"hoveredObject",get_hoveredObject,set_hoveredObject,false);
		addMember(l,"currentRay",get_currentRay,null,false);
		addMember(l,"cachedCamera",get_cachedCamera,null,true);
		addMember(l,"selectedObject",get_selectedObject,set_selectedObject,false);
		addMember(l,"touchCount",get_touchCount,null,false);
		addMember(l,"dragCount",get_dragCount,null,false);
		addMember(l,"mainCamera",get_mainCamera,null,false);
		addMember(l,"eventHandler",get_eventHandler,null,false);
		createTypeMetatable(l,constructor, typeof(UICamera),typeof(UnityEngine.MonoBehaviour));
	}
}
