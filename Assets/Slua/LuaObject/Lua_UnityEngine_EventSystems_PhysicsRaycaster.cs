using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PhysicsRaycaster : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.EventSystems.PhysicsRaycaster self=checkSelf<UnityEngine.EventSystems.PhysicsRaycaster>(l);
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
		UnityEngine.EventSystems.PhysicsRaycaster o = checkSelf<UnityEngine.EventSystems.PhysicsRaycaster>(l);
		pushValue(l,o.eventCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = checkSelf<UnityEngine.EventSystems.PhysicsRaycaster>(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalEventMask(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = checkSelf<UnityEngine.EventSystems.PhysicsRaycaster>(l);
		pushValue(l,o.finalEventMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventMask(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = checkSelf<UnityEngine.EventSystems.PhysicsRaycaster>(l);
		pushValue(l,o.eventMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventMask(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = checkSelf<UnityEngine.EventSystems.PhysicsRaycaster>(l);
		UnityEngine.LayerMask v;
		checkType(l,2,out v);
		o.eventMask=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PhysicsRaycaster");
		addMember(l,Raycast, "Raycast");
		addMember(l,get_eventCamera, "get_eventCamera");
		addMember(l,get_depth, "get_depth");
		addMember(l,get_finalEventMask, "get_finalEventMask");
		addMember(l,get_eventMask, "get_eventMask");
		addMember(l,set_eventMask, "set_eventMask");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.PhysicsRaycaster),typeof(UnityEngine.EventSystems.BaseRaycaster));
		LuaDLL.lua_pop(l, 1);
	}
}
