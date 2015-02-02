using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PointerEventData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o;
		UnityEngine.EventSystems.EventSystem a1;
		checkType(l,2,out a1);
		o=new UnityEngine.EventSystems.PointerEventData(a1);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointerMoving(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerEventData self=(UnityEngine.EventSystems.PointerEventData)checkSelf(l);
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
			UnityEngine.EventSystems.PointerEventData self=(UnityEngine.EventSystems.PointerEventData)checkSelf(l);
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
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pointerEnter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerEnter(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.pointerEnter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.lastPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawPointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.rawPointerPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rawPointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.rawPointerPress=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerDrag(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pointerDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerDrag(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.pointerDrag=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerCurrentRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pointerCurrentRaycast);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerCurrentRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.EventSystems.RaycastResult v;
		checkType(l,2,out v);
		o.pointerCurrentRaycast=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerPressRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pointerPressRaycast);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerPressRaycast(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.EventSystems.RaycastResult v;
		checkType(l,2,out v);
		o.pointerPressRaycast=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eligibleForClick(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.eligibleForClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eligibleForClick(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.eligibleForClick=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerId(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pointerId);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerId(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.pointerId=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.position=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.delta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.delta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pressPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pressPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.worldPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldPosition(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldNormal(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.worldNormal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldNormal(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.worldNormal=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickTime(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.clickTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickTime(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.clickTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickCount(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.clickCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickCount(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.clickCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollDelta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.scrollDelta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollDelta(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.scrollDelta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.useDragThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useDragThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dragging(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.dragging);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dragging(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.dragging=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_button(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushEnum(l,(int)o.button);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_button(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.EventSystems.PointerEventData.InputButton v;
		checkEnum(l,2,out v);
		o.button=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enterEventCamera(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.enterEventCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressEventCamera(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pressEventCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		pushValue(l,o.pointerPress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pointerPress(IntPtr l) {
		UnityEngine.EventSystems.PointerEventData o = (UnityEngine.EventSystems.PointerEventData)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.pointerPress=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PointerEventData");
		addMember(l,IsPointerMoving);
		addMember(l,IsScrolling);
		addMember(l,"pointerEnter",get_pointerEnter,set_pointerEnter,true);
		addMember(l,"lastPress",get_lastPress,null,true);
		addMember(l,"rawPointerPress",get_rawPointerPress,set_rawPointerPress,true);
		addMember(l,"pointerDrag",get_pointerDrag,set_pointerDrag,true);
		addMember(l,"pointerCurrentRaycast",get_pointerCurrentRaycast,set_pointerCurrentRaycast,true);
		addMember(l,"pointerPressRaycast",get_pointerPressRaycast,set_pointerPressRaycast,true);
		addMember(l,"eligibleForClick",get_eligibleForClick,set_eligibleForClick,true);
		addMember(l,"pointerId",get_pointerId,set_pointerId,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"delta",get_delta,set_delta,true);
		addMember(l,"pressPosition",get_pressPosition,set_pressPosition,true);
		addMember(l,"worldPosition",get_worldPosition,set_worldPosition,true);
		addMember(l,"worldNormal",get_worldNormal,set_worldNormal,true);
		addMember(l,"clickTime",get_clickTime,set_clickTime,true);
		addMember(l,"clickCount",get_clickCount,set_clickCount,true);
		addMember(l,"scrollDelta",get_scrollDelta,set_scrollDelta,true);
		addMember(l,"useDragThreshold",get_useDragThreshold,set_useDragThreshold,true);
		addMember(l,"dragging",get_dragging,set_dragging,true);
		addMember(l,"button",get_button,set_button,true);
		addMember(l,"enterEventCamera",get_enterEventCamera,null,true);
		addMember(l,"pressEventCamera",get_pressEventCamera,null,true);
		addMember(l,"pointerPress",get_pointerPress,set_pointerPress,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.PointerEventData),typeof(UnityEngine.EventSystems.BaseEventData));
	}
}
