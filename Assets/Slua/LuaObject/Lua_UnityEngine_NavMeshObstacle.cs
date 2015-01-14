using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshObstacle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.NavMeshObstacle o;
		if(matchType(l,1)){
			o=new UnityEngine.NavMeshObstacle();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_carving(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		pushValue(l,o.carving);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_carving(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.carving=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_carvingMoveThreshold(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		pushValue(l,o.carvingMoveThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_carvingMoveThreshold(IntPtr l) {
		UnityEngine.NavMeshObstacle o = checkSelf<UnityEngine.NavMeshObstacle>(l);
		System.Single v;
		checkType(l,2,out v);
		o.carvingMoveThreshold=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshObstacle");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_radius, "get_radius");
		addMember(l,set_radius, "set_radius");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,set_velocity, "set_velocity");
		addMember(l,get_carving, "get_carving");
		addMember(l,set_carving, "set_carving");
		addMember(l,get_carvingMoveThreshold, "get_carvingMoveThreshold");
		addMember(l,set_carvingMoveThreshold, "set_carvingMoveThreshold");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.NavMeshObstacle),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
