using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mask(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		pushValue(l,o.mask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mask(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.mask=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hit(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		pushValue(l,o.hit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hit(IntPtr l) {
		UnityEngine.NavMeshHit o = (UnityEngine.NavMeshHit)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.hit=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshHit");
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"normal",get_normal,set_normal,true);
		addMember(l,"distance",get_distance,set_distance,true);
		addMember(l,"mask",get_mask,set_mask,true);
		addMember(l,"hit",get_hit,set_hit,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshHit));
	}
}
