using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshTriangulation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		UnityEngine.NavMeshTriangulation o = (UnityEngine.NavMeshTriangulation)checkSelf(l);
		pushValue(l,o.vertices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vertices(IntPtr l) {
		UnityEngine.NavMeshTriangulation o = (UnityEngine.NavMeshTriangulation)checkSelf(l);
		UnityEngine.Vector3[] v;
		checkType(l,2,out v);
		o.vertices=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_indices(IntPtr l) {
		UnityEngine.NavMeshTriangulation o = (UnityEngine.NavMeshTriangulation)checkSelf(l);
		pushValue(l,o.indices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_indices(IntPtr l) {
		UnityEngine.NavMeshTriangulation o = (UnityEngine.NavMeshTriangulation)checkSelf(l);
		System.Int32[] v;
		checkType(l,2,out v);
		o.indices=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layers(IntPtr l) {
		UnityEngine.NavMeshTriangulation o = (UnityEngine.NavMeshTriangulation)checkSelf(l);
		pushValue(l,o.layers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layers(IntPtr l) {
		UnityEngine.NavMeshTriangulation o = (UnityEngine.NavMeshTriangulation)checkSelf(l);
		System.Int32[] v;
		checkType(l,2,out v);
		o.layers=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshTriangulation");
		addMember(l,"vertices",get_vertices,set_vertices);
		addMember(l,"indices",get_indices,set_indices);
		addMember(l,"layers",get_layers,set_layers);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshTriangulation));
	}
}
