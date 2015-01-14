using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_RaycastResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.EventSystems.RaycastResult self=checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
			self.Clear();
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_module(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		pushValue(l,o.module);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_module(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		UnityEngine.EventSystems.BaseRaycaster v;
		checkType(l,2,out v);
		o.module=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		System.Single v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_index(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		pushValue(l,o.index);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_index(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		System.Single v;
		checkType(l,2,out v);
		o.index=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.depth=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gameObject(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.gameObject=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = checkSelf<UnityEngine.EventSystems.RaycastResult>(l);
		pushValue(l,o.isValid);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.RaycastResult");
		addMember(l,Clear, "Clear");
		addMember(l,get_module, "get_module");
		addMember(l,set_module, "set_module");
		addMember(l,get_distance, "get_distance");
		addMember(l,set_distance, "set_distance");
		addMember(l,get_index, "get_index");
		addMember(l,set_index, "set_index");
		addMember(l,get_depth, "get_depth");
		addMember(l,set_depth, "set_depth");
		addMember(l,get_gameObject, "get_gameObject");
		addMember(l,set_gameObject, "set_gameObject");
		addMember(l,get_isValid, "get_isValid");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.RaycastResult));
		LuaDLL.lua_pop(l, 1);
	}
}
