using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_BaseInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Process(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseInputModule self=checkSelf<UnityEngine.EventSystems.BaseInputModule>(l);
			self.Process();
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
			UnityEngine.EventSystems.BaseInputModule self=checkSelf<UnityEngine.EventSystems.BaseInputModule>(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsPointerOverGameObject(a1);
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
			UnityEngine.EventSystems.BaseInputModule self=checkSelf<UnityEngine.EventSystems.BaseInputModule>(l);
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
	static public int DeactivateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseInputModule self=checkSelf<UnityEngine.EventSystems.BaseInputModule>(l);
			self.DeactivateModule();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseInputModule self=checkSelf<UnityEngine.EventSystems.BaseInputModule>(l);
			self.ActivateModule();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.BaseInputModule self=checkSelf<UnityEngine.EventSystems.BaseInputModule>(l);
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
			UnityEngine.EventSystems.BaseInputModule self=checkSelf<UnityEngine.EventSystems.BaseInputModule>(l);
			System.Boolean ret=self.IsModuleSupported();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.BaseInputModule");
		addMember(l,Process, "Process");
		addMember(l,IsPointerOverGameObject, "IsPointerOverGameObject");
		addMember(l,ShouldActivateModule, "ShouldActivateModule");
		addMember(l,DeactivateModule, "DeactivateModule");
		addMember(l,ActivateModule, "ActivateModule");
		addMember(l,UpdateModule, "UpdateModule");
		addMember(l,IsModuleSupported, "IsModuleSupported");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.BaseInputModule),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
