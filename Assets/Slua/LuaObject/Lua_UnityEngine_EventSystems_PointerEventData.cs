using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PointerEventData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.EventSystems.PointerEventData o;
		if(matchType(l,1,typeof(UnityEngine.EventSystems.EventSystem))){
			UnityEngine.EventSystems.EventSystem a1;
			checkType(l,1,out a1);
			o=new UnityEngine.EventSystems.PointerEventData(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointerMoving(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerEventData self=checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
			System.Boolean ret=self.IsPointerMoving();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsScrolling(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerEventData self=checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
			System.Boolean ret=self.IsScrolling();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerEnter(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pointerEnter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerEnter(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.pointerEnter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.lastPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawPointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.rawPointerPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rawPointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.rawPointerPress=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerDrag(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pointerDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerDrag(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.pointerDrag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerCurrentRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pointerCurrentRaycast);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerCurrentRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.EventSystems.RaycastResult v;
		checkType(l,2,out v);
		o.pointerCurrentRaycast=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerPressRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pointerPressRaycast);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerPressRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.EventSystems.RaycastResult v;
		checkType(l,2,out v);
		o.pointerPressRaycast=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eligibleForClick(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.eligibleForClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eligibleForClick(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.eligibleForClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerId(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pointerId);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerId(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.pointerId=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.position=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.delta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.delta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pressPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pressPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.worldPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldNormal(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.worldNormal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldNormal(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldNormal=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickTime(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.clickTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickTime(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		System.Single v;
		checkType(l,2,out v);
		o.clickTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickCount(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.clickCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickCount(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.clickCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollDelta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.scrollDelta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollDelta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.scrollDelta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.useDragThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useDragThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragging(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.dragging);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragging(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.dragging=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_button(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.button);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_button(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.EventSystems.PointerEventData.InputButton v;
		checkEnum(l,2,out v);
		o.button=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enterEventCamera(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.enterEventCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressEventCamera(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pressEventCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		pushValue(l,o.pointerPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = checkSelf<UnityEngine.EventSystems.PointerEventData>(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.pointerPress=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PointerEventData");
		addMember(l,IsPointerMoving, "IsPointerMoving");
		addMember(l,IsScrolling, "IsScrolling");
		addMember(l,get_pointerEnter, "get_pointerEnter");
		addMember(l,set_pointerEnter, "set_pointerEnter");
		addMember(l,get_lastPress, "get_lastPress");
		addMember(l,get_rawPointerPress, "get_rawPointerPress");
		addMember(l,set_rawPointerPress, "set_rawPointerPress");
		addMember(l,get_pointerDrag, "get_pointerDrag");
		addMember(l,set_pointerDrag, "set_pointerDrag");
		addMember(l,get_pointerCurrentRaycast, "get_pointerCurrentRaycast");
		addMember(l,set_pointerCurrentRaycast, "set_pointerCurrentRaycast");
		addMember(l,get_pointerPressRaycast, "get_pointerPressRaycast");
		addMember(l,set_pointerPressRaycast, "set_pointerPressRaycast");
		addMember(l,get_eligibleForClick, "get_eligibleForClick");
		addMember(l,set_eligibleForClick, "set_eligibleForClick");
		addMember(l,get_pointerId, "get_pointerId");
		addMember(l,set_pointerId, "set_pointerId");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_delta, "get_delta");
		addMember(l,set_delta, "set_delta");
		addMember(l,get_pressPosition, "get_pressPosition");
		addMember(l,set_pressPosition, "set_pressPosition");
		addMember(l,get_worldPosition, "get_worldPosition");
		addMember(l,set_worldPosition, "set_worldPosition");
		addMember(l,get_worldNormal, "get_worldNormal");
		addMember(l,set_worldNormal, "set_worldNormal");
		addMember(l,get_clickTime, "get_clickTime");
		addMember(l,set_clickTime, "set_clickTime");
		addMember(l,get_clickCount, "get_clickCount");
		addMember(l,set_clickCount, "set_clickCount");
		addMember(l,get_scrollDelta, "get_scrollDelta");
		addMember(l,set_scrollDelta, "set_scrollDelta");
		addMember(l,get_useDragThreshold, "get_useDragThreshold");
		addMember(l,set_useDragThreshold, "set_useDragThreshold");
		addMember(l,get_dragging, "get_dragging");
		addMember(l,set_dragging, "set_dragging");
		addMember(l,get_button, "get_button");
		addMember(l,set_button, "set_button");
		addMember(l,get_enterEventCamera, "get_enterEventCamera");
		addMember(l,get_pressEventCamera, "get_pressEventCamera");
		addMember(l,get_pointerPress, "get_pointerPress");
		addMember(l,set_pointerPress, "set_pointerPress");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.PointerEventData),typeof(UnityEngine.EventSystems.BaseEventData));
		LuaDLL.lua_pop(l, 1);
	}
}
