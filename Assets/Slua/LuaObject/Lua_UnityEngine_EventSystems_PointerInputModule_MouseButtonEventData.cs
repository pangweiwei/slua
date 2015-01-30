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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PressedThisFrame(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData self=(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)checkSelf(l);
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
			UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData self=(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)checkSelf(l);
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
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)checkSelf(l);
		pushValue(l,o.buttonState);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_buttonState(IntPtr l) {
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)checkSelf(l);
		UnityEngine.EventSystems.PointerEventData.FramePressState v;
		checkEnum(l,2,out v);
		o.buttonState=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_buttonData(IntPtr l) {
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)checkSelf(l);
		pushValue(l,o.buttonData);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_buttonData(IntPtr l) {
		UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData o = (UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData)checkSelf(l);
		UnityEngine.EventSystems.PointerEventData v;
		checkType(l,2,out v);
		o.buttonData=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData");
		addMember(l,PressedThisFrame);
		addMember(l,ReleasedThisFrame);
		addMember(l,"buttonState",get_buttonState,set_buttonState,true);
		addMember(l,"buttonData",get_buttonData,set_buttonData,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData));
	}
}
