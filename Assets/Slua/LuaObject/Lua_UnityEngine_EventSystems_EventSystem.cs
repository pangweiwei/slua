using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_EventSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModules(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
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
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
				UnityEngine.GameObject a1;
				checkType(l,2,out a1);
				UnityEngine.EventSystems.BaseEventData a2;
				checkType(l,3,out a2);
				self.SetSelectedGameObject(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.GameObject))){
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
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
			UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
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
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
				System.Boolean ret=self.IsPointerOverGameObject();
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.EventSystems.EventSystem self=(UnityEngine.EventSystems.EventSystem)checkSelf(l);
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
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		pushValue(l,o.sendNavigationEvents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sendNavigationEvents(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.sendNavigationEvents=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		pushValue(l,o.pixelDragThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelDragThreshold(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.pixelDragThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentInputModule(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		pushValue(l,o.currentInputModule);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_firstSelectedGameObject(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		pushValue(l,o.firstSelectedGameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentSelectedGameObject(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		pushValue(l,o.currentSelectedGameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastSelectedGameObject(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		pushValue(l,o.lastSelectedGameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alreadySelecting(IntPtr l) {
		UnityEngine.EventSystems.EventSystem o = (UnityEngine.EventSystems.EventSystem)checkSelf(l);
		pushValue(l,o.alreadySelecting);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.EventSystem");
		addMember(l,UpdateModules);
		addMember(l,SetSelectedGameObject);
		addMember(l,RaycastAll);
		addMember(l,IsPointerOverGameObject);
		addMember(l,"current",get_current,set_current);
		addMember(l,"sendNavigationEvents",get_sendNavigationEvents,set_sendNavigationEvents);
		addMember(l,"pixelDragThreshold",get_pixelDragThreshold,set_pixelDragThreshold);
		addMember(l,"currentInputModule",get_currentInputModule,null);
		addMember(l,"firstSelectedGameObject",get_firstSelectedGameObject,null);
		addMember(l,"currentSelectedGameObject",get_currentSelectedGameObject,null);
		addMember(l,"lastSelectedGameObject",get_lastSelectedGameObject,null);
		addMember(l,"alreadySelecting",get_alreadySelecting,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.EventSystem),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
