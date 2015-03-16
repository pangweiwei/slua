using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.EventSystems.EventTrigger.TriggerEvent o;
		o=new UnityEngine.EventSystems.EventTrigger.TriggerEvent();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.reg(l);
		getTypeTable(l,"UnityEngine.EventSystems.EventTrigger.TriggerEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent),typeof(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData));
	}
}
