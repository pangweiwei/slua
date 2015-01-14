using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_EventTrigger_TriggerEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.EventSystems.EventTrigger.TriggerEvent o;
		if(matchType(l,1)){
			o=new UnityEngine.EventSystems.EventTrigger.TriggerEvent();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_BaseEventData.reg(l);
		getTypeTable(l,"UnityEngine.EventSystems.EventTrigger.TriggerEvent");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent),typeof(LuaUnityEvent_BaseEventData));
		LuaDLL.lua_pop(l, 1);
	}
}
