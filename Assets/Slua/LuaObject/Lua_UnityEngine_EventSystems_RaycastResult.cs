using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_RaycastResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.EventSystems.RaycastResult self=(UnityEngine.EventSystems.RaycastResult)checkSelf(l);
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
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		pushValue(l,o.module);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_module(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		UnityEngine.EventSystems.BaseRaycaster v;
		checkType(l,2,out v);
		o.module=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_index(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		pushValue(l,o.index);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_index(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.index=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.depth=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gameObject(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.gameObject=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o = (UnityEngine.EventSystems.RaycastResult)checkSelf(l);
		pushValue(l,o.isValid);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.RaycastResult");
		addMember(l,Clear);
		addMember(l,"module",get_module,set_module);
		addMember(l,"distance",get_distance,set_distance);
		addMember(l,"index",get_index,set_index);
		addMember(l,"depth",get_depth,set_depth);
		addMember(l,"gameObject",get_gameObject,set_gameObject);
		addMember(l,"isValid",get_isValid,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.RaycastResult));
	}
}
