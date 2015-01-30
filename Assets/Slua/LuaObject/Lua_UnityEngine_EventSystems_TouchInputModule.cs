using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_TouchInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.TouchInputModule self=(UnityEngine.EventSystems.TouchInputModule)checkSelf(l);
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
			UnityEngine.EventSystems.TouchInputModule self=(UnityEngine.EventSystems.TouchInputModule)checkSelf(l);
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
			UnityEngine.EventSystems.TouchInputModule self=(UnityEngine.EventSystems.TouchInputModule)checkSelf(l);
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
			UnityEngine.EventSystems.TouchInputModule self=(UnityEngine.EventSystems.TouchInputModule)checkSelf(l);
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
			UnityEngine.EventSystems.TouchInputModule self=(UnityEngine.EventSystems.TouchInputModule)checkSelf(l);
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
		UnityEngine.EventSystems.TouchInputModule o = (UnityEngine.EventSystems.TouchInputModule)checkSelf(l);
		pushValue(l,o.allowActivationOnStandalone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowActivationOnStandalone(IntPtr l) {
		UnityEngine.EventSystems.TouchInputModule o = (UnityEngine.EventSystems.TouchInputModule)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.allowActivationOnStandalone=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.TouchInputModule");
		addMember(l,UpdateModule);
		addMember(l,IsModuleSupported);
		addMember(l,ShouldActivateModule);
		addMember(l,Process);
		addMember(l,DeactivateModule);
		addMember(l,"allowActivationOnStandalone",get_allowActivationOnStandalone,set_allowActivationOnStandalone,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.TouchInputModule),typeof(UnityEngine.EventSystems.PointerInputModule));
	}
}
