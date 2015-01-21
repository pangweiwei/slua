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
			UnityEngine.UI.ToggleGroup self=(UnityEngine.UI.ToggleGroup)checkSelf(l);
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
			UnityEngine.UI.ToggleGroup self=(UnityEngine.UI.ToggleGroup)checkSelf(l);
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
			UnityEngine.UI.ToggleGroup self=(UnityEngine.UI.ToggleGroup)checkSelf(l);
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
			UnityEngine.UI.ToggleGroup self=(UnityEngine.UI.ToggleGroup)checkSelf(l);
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
			UnityEngine.UI.ToggleGroup self=(UnityEngine.UI.ToggleGroup)checkSelf(l);
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
			UnityEngine.UI.ToggleGroup self=(UnityEngine.UI.ToggleGroup)checkSelf(l);
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
		UnityEngine.UI.ToggleGroup o = (UnityEngine.UI.ToggleGroup)checkSelf(l);
		pushValue(l,o.allowSwitchOff);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowSwitchOff(IntPtr l) {
		UnityEngine.UI.ToggleGroup o = (UnityEngine.UI.ToggleGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.allowSwitchOff=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ToggleGroup");
		addMember(l,NotifyToggleOn);
		addMember(l,UnregisterToggle);
		addMember(l,RegisterToggle);
		addMember(l,AnyTogglesOn);
		addMember(l,ActiveToggles);
		addMember(l,SetAllTogglesOff);
		addMember(l,"allowSwitchOff",get_allowSwitchOff,set_allowSwitchOff);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.ToggleGroup),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
