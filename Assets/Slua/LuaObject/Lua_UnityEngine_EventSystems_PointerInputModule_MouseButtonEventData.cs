using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o;
		if(matchType(l,1)){
			o=new UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PressedThisFrame(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData self=checkSelf<UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData>(l);
			System.Boolean ret=self.PressedThisFrame();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReleasedThisFrame(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData self=checkSelf<UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData>(l);
			System.Boolean ret=self.ReleasedThisFrame();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_buttonState(IntPtr l) {
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = checkSelf<UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData>(l);
		pushValue(l,o.buttonState);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_buttonState(IntPtr l) {
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = checkSelf<UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData>(l);
		UnityEngine.EventSystems.PointerEventData.FramePressState v;
		checkEnum(l,2,out v);
		o.buttonState=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_buttonData(IntPtr l) {
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = checkSelf<UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData>(l);
		pushValue(l,o.buttonData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_buttonData(IntPtr l) {
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = checkSelf<UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData>(l);
		UnityEngine.EventSystems.PointerEventData v;
		checkType(l,2,out v);
		o.buttonData=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData");
		addMember(l,PressedThisFrame, "PressedThisFrame");
		addMember(l,ReleasedThisFrame, "ReleasedThisFrame");
		addMember(l,get_buttonState, "get_buttonState");
		addMember(l,set_buttonState, "set_buttonState");
		addMember(l,get_buttonData, "get_buttonData");
		addMember(l,set_buttonData, "set_buttonData");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData));
		LuaDLL.lua_pop(l, 1);
	}
}
