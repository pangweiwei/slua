using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_EventTrigger_Entry : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.EventSystems.EventTrigger.Entry o;
		if(matchType(l,1)){
			o=new UnityEngine.EventSystems.EventTrigger.Entry();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_eventID(IntPtr l) {
		UnityEngine.EventSystems.EventTrigger.Entry o = checkSelf<UnityEngine.EventSystems.EventTrigger.Entry>(l);
		pushValue(l,o.eventID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_eventID(IntPtr l) {
		UnityEngine.EventSystems.EventTrigger.Entry o = checkSelf<UnityEngine.EventSystems.EventTrigger.Entry>(l);
		UnityEngine.EventSystems.EventTriggerType v;
		checkEnum(l,2,out v);
		o.eventID=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_callback(IntPtr l) {
		UnityEngine.EventSystems.EventTrigger.Entry o = checkSelf<UnityEngine.EventSystems.EventTrigger.Entry>(l);
		pushValue(l,o.callback);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_callback(IntPtr l) {
		UnityEngine.EventSystems.EventTrigger.Entry o = checkSelf<UnityEngine.EventSystems.EventTrigger.Entry>(l);
		UnityEngine.EventSystems.EventTrigger.TriggerEvent v;
		checkType(l,2,out v);
		o.callback=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.EventTrigger.Entry");
		addMember(l,get_eventID, "get_eventID");
		addMember(l,set_eventID, "set_eventID");
		addMember(l,get_callback, "get_callback");
		addMember(l,set_callback, "set_callback");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.EventTrigger.Entry));
		LuaDLL.lua_pop(l, 1);
	}
}
