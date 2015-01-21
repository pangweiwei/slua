using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_StandaloneInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
	static public int ActivateModule(IntPtr l) {
		try{
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.ActivateModule();
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
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.DeactivateModule();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Process(IntPtr l) {
		try{
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.Process();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allowActivationOnMobileDevice(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		pushValue(l,o.allowActivationOnMobileDevice);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowActivationOnMobileDevice(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.allowActivationOnMobileDevice=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputActionsPerSecond(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		pushValue(l,o.inputActionsPerSecond);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputActionsPerSecond(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.inputActionsPerSecond=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalAxis(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		pushValue(l,o.horizontalAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalAxis(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.horizontalAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAxis(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		pushValue(l,o.verticalAxis);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalAxis(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.verticalAxis=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_submitButton(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		pushValue(l,o.submitButton);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_submitButton(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.submitButton=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cancelButton(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		pushValue(l,o.cancelButton);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cancelButton(IntPtr l) {
		UnityEngine.EventSystems.StandaloneInputModule o = (UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.cancelButton=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.StandaloneInputModule");
		addMember(l,UpdateModule);
		addMember(l,IsModuleSupported);
		addMember(l,ShouldActivateModule);
		addMember(l,ActivateModule);
		addMember(l,DeactivateModule);
		addMember(l,Process);
		addMember(l,"allowActivationOnMobileDevice",get_allowActivationOnMobileDevice,set_allowActivationOnMobileDevice);
		addMember(l,"inputActionsPerSecond",get_inputActionsPerSecond,set_inputActionsPerSecond);
		addMember(l,"horizontalAxis",get_horizontalAxis,set_horizontalAxis);
		addMember(l,"verticalAxis",get_verticalAxis,set_verticalAxis);
		addMember(l,"submitButton",get_submitButton,set_submitButton);
		addMember(l,"cancelButton",get_cancelButton,set_cancelButton);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.StandaloneInputModule),typeof(UnityEngine.EventSystems.PointerInputModule));
	}
}
