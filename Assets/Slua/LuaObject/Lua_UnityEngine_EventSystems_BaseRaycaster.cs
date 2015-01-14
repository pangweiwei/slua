using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_BaseRaycaster : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseRaycaster self=checkSelf<UnityEngine.EventSystems.BaseRaycaster>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			List<UnityEngine.EventSystems.RaycastResult> a2;
			checkType(l,3,out a2);
			self.Raycast(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventCamera(IntPtr l) {
		UnityEngine.EventSystems.BaseRaycaster o = checkSelf<UnityEngine.EventSystems.BaseRaycaster>(l);
		pushValue(l,o.eventCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortOrderPriority(IntPtr l) {
		UnityEngine.EventSystems.BaseRaycaster o = checkSelf<UnityEngine.EventSystems.BaseRaycaster>(l);
		pushValue(l,o.sortOrderPriority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderOrderPriority(IntPtr l) {
		UnityEngine.EventSystems.BaseRaycaster o = checkSelf<UnityEngine.EventSystems.BaseRaycaster>(l);
		pushValue(l,o.renderOrderPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.BaseRaycaster");
		addMember(l,Raycast, "Raycast");
		addMember(l,get_eventCamera, "get_eventCamera");
		addMember(l,get_sortOrderPriority, "get_sortOrderPriority");
		addMember(l,get_renderOrderPriority, "get_renderOrderPriority");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.BaseRaycaster),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
