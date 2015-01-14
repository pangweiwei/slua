using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		System.Single v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mask(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		pushValue(l,o.mask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mask(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.mask=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hit(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		pushValue(l,o.hit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hit(IntPtr l) {
		UnityEngine.NavMeshHit o = checkSelf<UnityEngine.NavMeshHit>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.hit=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshHit");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_normal, "get_normal");
		addMember(l,set_normal, "set_normal");
		addMember(l,get_distance, "get_distance");
		addMember(l,set_distance, "set_distance");
		addMember(l,get_mask, "get_mask");
		addMember(l,set_mask, "set_mask");
		addMember(l,get_hit, "get_hit");
		addMember(l,set_hit, "set_hit");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.NavMeshHit));
		LuaDLL.lua_pop(l, 1);
	}
}
