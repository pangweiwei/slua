using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_EventSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModules(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventSystem self=checkSelf<UnityEngine.EventSystems.EventSystem>(l);
			self.UpdateModules();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSelectedGameObject(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.GameObject),typeof(UnityEngine.EventSystems.BaseEventData))){
				UnityEngine.EventSystems.EventSystem self=checkSelf<UnityEngine.EventSystems.EventSystem>(l);
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				UnityEngine.EventSystems.BaseEventData a2;
				checkType(l,3,out a2);
				self.SetSelectedGameObject(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.GameObject))){
				UnityEngine.EventSystems.EventSystem self=checkSelf<UnityEngine.EventSystems.EventSystem>(l);
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				self.SetSelectedGameObject(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RaycastAll(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventSystem self=checkSelf<UnityEngine.EventSystems.EventSystem>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			List<UnityEngine.EventSystems.RaycastResult> a2;
			checkType(l,3,out a2);
			self.RaycastAll(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointerOverGameObject(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.EventSystems.EventSystem self=checkSelf<UnityEngine.EventSystems.EventSystem>(l);
				System.Boolean ret=self.IsPointerOverGameObject();
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.EventSystems.EventSystem self=checkSelf<UnityEngine.EventSystems.EventSystem>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.IsPointerOverGameObject(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		pushValue(l,UnityEngine.EventSystems.EventSystem.current);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		UnityEngine.EventSystems.EventSystem v;
		checkType(l,2,out v);
		UnityEngine.EventSystems.EventSystem.current=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sendNavigationEvents(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		pushValue(l,o.sendNavigationEvents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sendNavigationEvents(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.sendNavigationEvents=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		pushValue(l,o.pixelDragThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.pixelDragThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentInputModule(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		pushValue(l,o.currentInputModule);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_firstSelectedGameObject(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		pushValue(l,o.firstSelectedGameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentSelectedGameObject(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		pushValue(l,o.currentSelectedGameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastSelectedGameObject(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		pushValue(l,o.lastSelectedGameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alreadySelecting(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = checkSelf<UnityEngine.EventSystems.EventSystem>(l);
		pushValue(l,o.alreadySelecting);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.EventSystem");
		addMember(l,UpdateModules, "UpdateModules");
		addMember(l,SetSelectedGameObject, "SetSelectedGameObject");
		addMember(l,RaycastAll, "RaycastAll");
		addMember(l,IsPointerOverGameObject, "IsPointerOverGameObject");
		addMember(l,get_current, "get_current");
		addMember(l,set_current, "set_current");
		addMember(l,get_sendNavigationEvents, "get_sendNavigationEvents");
		addMember(l,set_sendNavigationEvents, "set_sendNavigationEvents");
		addMember(l,get_pixelDragThreshold, "get_pixelDragThreshold");
		addMember(l,set_pixelDragThreshold, "set_pixelDragThreshold");
		addMember(l,get_currentInputModule, "get_currentInputModule");
		addMember(l,get_firstSelectedGameObject, "get_firstSelectedGameObject");
		addMember(l,get_currentSelectedGameObject, "get_currentSelectedGameObject");
		addMember(l,get_lastSelectedGameObject, "get_lastSelectedGameObject");
		addMember(l,get_alreadySelecting, "get_alreadySelecting");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.EventSystem),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
