using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ToggleGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int NotifyToggleOn(IntPtr l) {
		try{
			UnityEngine.UI.ToggleGroup self=checkSelf<UnityEngine.UI.ToggleGroup>(l);
			UnityEngine.UI.Toggle a1;
			checkType(l,2,out a1);
			self.NotifyToggleOn(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnregisterToggle(IntPtr l) {
		try{
			UnityEngine.UI.ToggleGroup self=checkSelf<UnityEngine.UI.ToggleGroup>(l);
			UnityEngine.UI.Toggle a1;
			checkType(l,2,out a1);
			self.UnregisterToggle(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterToggle(IntPtr l) {
		try{
			UnityEngine.UI.ToggleGroup self=checkSelf<UnityEngine.UI.ToggleGroup>(l);
			UnityEngine.UI.Toggle a1;
			checkType(l,2,out a1);
			self.RegisterToggle(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AnyTogglesOn(IntPtr l) {
		try{
			UnityEngine.UI.ToggleGroup self=checkSelf<UnityEngine.UI.ToggleGroup>(l);
			System.Boolean ret=self.AnyTogglesOn();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActiveToggles(IntPtr l) {
		try{
			UnityEngine.UI.ToggleGroup self=checkSelf<UnityEngine.UI.ToggleGroup>(l);
			IEnumerable<UnityEngine.UI.Toggle> ret=self.ActiveToggles();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAllTogglesOff(IntPtr l) {
		try{
			UnityEngine.UI.ToggleGroup self=checkSelf<UnityEngine.UI.ToggleGroup>(l);
			self.SetAllTogglesOff();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allowSwitchOff(IntPtr l) {
		UnityEngine.UI.ToggleGroup o = checkSelf<UnityEngine.UI.ToggleGroup>(l);
		pushValue(l,o.allowSwitchOff);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowSwitchOff(IntPtr l) {
		UnityEngine.UI.ToggleGroup o = checkSelf<UnityEngine.UI.ToggleGroup>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.allowSwitchOff=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ToggleGroup");
		addMember(l,NotifyToggleOn, "NotifyToggleOn");
		addMember(l,UnregisterToggle, "UnregisterToggle");
		addMember(l,RegisterToggle, "RegisterToggle");
		addMember(l,AnyTogglesOn, "AnyTogglesOn");
		addMember(l,ActiveToggles, "ActiveToggles");
		addMember(l,SetAllTogglesOff, "SetAllTogglesOff");
		addMember(l,get_allowSwitchOff, "get_allowSwitchOff");
		addMember(l,set_allowSwitchOff, "set_allowSwitchOff");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.ToggleGroup),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
