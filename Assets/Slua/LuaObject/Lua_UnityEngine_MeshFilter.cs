using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.MeshFilter o;
		if(matchType(l,1)){
			o=new UnityEngine.MeshFilter();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mesh(IntPtr l) {
		UnityEngine.MeshFilter o = checkSelf<UnityEngine.MeshFilter>(l);
		pushValue(l,o.mesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mesh(IntPtr l) {
		UnityEngine.MeshFilter o = checkSelf<UnityEngine.MeshFilter>(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.mesh=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMesh(IntPtr l) {
		UnityEngine.MeshFilter o = checkSelf<UnityEngine.MeshFilter>(l);
		pushValue(l,o.sharedMesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMesh(IntPtr l) {
		UnityEngine.MeshFilter o = checkSelf<UnityEngine.MeshFilter>(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.sharedMesh=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshFilter");
		addMember(l,get_mesh, "get_mesh");
		addMember(l,set_mesh, "set_mesh");
		addMember(l,get_sharedMesh, "get_sharedMesh");
		addMember(l,set_sharedMesh, "set_sharedMesh");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.MeshFilter),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
