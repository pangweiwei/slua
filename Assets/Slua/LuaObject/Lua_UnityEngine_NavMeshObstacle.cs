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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_carving(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		pushValue(l,o.carving);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_carving(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.carving=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_carvingMoveThreshold(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		pushValue(l,o.carvingMoveThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_carvingMoveThreshold(IntPtr l) {
		UnityEngine.NavMeshObstacle o = (UnityEngine.NavMeshObstacle)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.carvingMoveThreshold=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshObstacle");
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"carving",get_carving,set_carving,true);
		addMember(l,"carvingMoveThreshold",get_carvingMoveThreshold,set_carvingMoveThreshold,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshObstacle),typeof(UnityEngine.Behaviour));
	}
}
