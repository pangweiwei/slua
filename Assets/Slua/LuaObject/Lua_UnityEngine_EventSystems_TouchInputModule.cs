using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_TouchInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.TouchInputModule self=checkSelf<UnityEngine.EventSystems.TouchInputModule>(l);
			self.UpdateModule();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsModuleSupported(IntPtr l) {
		try{
			UnityEngine.EventSystems.TouchInputModule self=checkSelf<UnityEngine.EventSystems.TouchInputModule>(l);
			System.Boolean ret=self.IsModuleSupported();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShouldActivateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.TouchInputModule self=checkSelf<UnityEngine.EventSystems.TouchInputModule>(l);
			System.Boolean ret=self.ShouldActivateModule();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Process(IntPtr l) {
		try{
			UnityEngine.EventSystems.TouchInputModule self=checkSelf<UnityEngine.EventSystems.TouchInputModule>(l);
			self.Process();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DeactivateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.TouchInputModule self=checkSelf<UnityEngine.EventSystems.TouchInputModule>(l);
			self.DeactivateModule();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allowActivationOnStandalone(IntPtr l) {
		UnityEngine.EventSystems.TouchInputModule o = checkSelf<UnityEngine.EventSystems.TouchInputModule>(l);
		pushValue(l,o.allowActivationOnStandalone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowActivationOnStandalone(IntPtr l) {
		UnityEngine.EventSystems.TouchInputModule o = checkSelf<UnityEngine.EventSystems.TouchInputModule>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.allowActivationOnStandalone=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.TouchInputModule");
		addMember(l,UpdateModule, "UpdateModule");
		addMember(l,IsModuleSupported, "IsModuleSupported");
		addMember(l,ShouldActivateModule, "ShouldActivateModule");
		addMember(l,Process, "Process");
		addMember(l,DeactivateModule, "DeactivateModule");
		addMember(l,get_allowActivationOnStandalone, "get_allowActivationOnStandalone");
		addMember(l,set_allowActivationOnStandalone, "set_allowActivationOnStandalone");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.TouchInputModule),typeof(UnityEngine.EventSystems.PointerInputModule));
		LuaDLL.lua_pop(l, 1);
	}
}
