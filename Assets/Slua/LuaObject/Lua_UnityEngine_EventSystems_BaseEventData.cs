using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_BaseEventData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.EventSystems.BaseEventData o;
		if(matchType(l,1,typeof(UnityEngine.EventSystems.EventSystem))){
			UnityEngine.EventSystems.EventSystem a1;
			checkType(l,1,out a1);
			o=new UnityEngine.EventSystems.BaseEventData(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseEventData self=checkSelf<UnityEngine.EventSystems.BaseEventData>(l);
			self.Reset();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Use(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseEventData self=checkSelf<UnityEngine.EventSystems.BaseEventData>(l);
			self.Use();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_used(IntPtr l) {
		UnityEngine.EventSystems.BaseEventData o = checkSelf<UnityEngine.EventSystems.BaseEventData>(l);
		pushValue(l,o.used);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentInputModule(IntPtr l) {
		UnityEngine.EventSystems.BaseEventData o = checkSelf<UnityEngine.EventSystems.BaseEventData>(l);
		pushValue(l,o.currentInputModule);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedObject(IntPtr l) {
		UnityEngine.EventSystems.BaseEventData o = checkSelf<UnityEngine.EventSystems.BaseEventData>(l);
		pushValue(l,o.selectedObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedObject(IntPtr l) {
		UnityEngine.EventSystems.BaseEventData o = checkSelf<UnityEngine.EventSystems.BaseEventData>(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.selectedObject=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.BaseEventData");
		addMember(l,Reset, "Reset");
		addMember(l,Use, "Use");
		addMember(l,get_used, "get_used");
		addMember(l,get_currentInputModule, "get_currentInputModule");
		addMember(l,get_selectedObject, "get_selectedObject");
		addMember(l,set_selectedObject, "set_selectedObject");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.BaseEventData));
		LuaDLL.lua_pop(l, 1);
	}
}
