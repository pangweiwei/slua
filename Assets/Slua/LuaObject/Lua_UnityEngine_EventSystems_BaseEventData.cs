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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reset(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseEventData self=(UnityEngine.EventSystems.BaseEventData)checkSelf(l);
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
			UnityEngine.EventSystems.BaseEventData self=(UnityEngine.EventSystems.BaseEventData)checkSelf(l);
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
		UnityEngine.EventSystems.BaseEventData o = (UnityEngine.EventSystems.BaseEventData)checkSelf(l);
		pushValue(l,o.used);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentInputModule(IntPtr l) {
		UnityEngine.EventSystems.BaseEventData o = (UnityEngine.EventSystems.BaseEventData)checkSelf(l);
		pushValue(l,o.currentInputModule);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectedObject(IntPtr l) {
		UnityEngine.EventSystems.BaseEventData o = (UnityEngine.EventSystems.BaseEventData)checkSelf(l);
		pushValue(l,o.selectedObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectedObject(IntPtr l) {
		UnityEngine.EventSystems.BaseEventData o = (UnityEngine.EventSystems.BaseEventData)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.selectedObject=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.BaseEventData");
		addMember(l,Reset);
		addMember(l,Use);
		addMember(l,"used",get_used,null);
		addMember(l,"currentInputModule",get_currentInputModule,null);
		addMember(l,"selectedObject",get_selectedObject,set_selectedObject);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.BaseEventData));
	}
}
