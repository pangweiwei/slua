using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PhysicsRaycaster : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> a2;
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
		UnityEngine.EventSystems.PhysicsRaycaster o = (UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
		pushValue(l,o.eventCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = (UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_finalEventMask(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = (UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
		pushValue(l,o.finalEventMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventMask(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = (UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
		pushValue(l,o.eventMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventMask(IntPtr l) {
		UnityEngine.EventSystems.PhysicsRaycaster o = (UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
		UnityEngine.LayerMask v;
		checkType(l,2,out v);
		o.eventMask=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PhysicsRaycaster");
		addMember(l,Raycast);
		addMember(l,"eventCamera",get_eventCamera,null,true);
		addMember(l,"depth",get_depth,null,true);
		addMember(l,"finalEventMask",get_finalEventMask,null,true);
		addMember(l,"eventMask",get_eventMask,set_eventMask,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.PhysicsRaycaster),typeof(UnityEngine.EventSystems.BaseRaycaster));
	}
}
