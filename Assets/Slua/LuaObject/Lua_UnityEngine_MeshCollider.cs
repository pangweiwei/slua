using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.MeshCollider o;
		if(matchType(l,1)){
			o=new UnityEngine.MeshCollider();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMesh(IntPtr l) {
		UnityEngine.MeshCollider o = checkSelf<UnityEngine.MeshCollider>(l);
		pushValue(l,o.sharedMesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMesh(IntPtr l) {
		UnityEngine.MeshCollider o = checkSelf<UnityEngine.MeshCollider>(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.sharedMesh=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_convex(IntPtr l) {
		UnityEngine.MeshCollider o = checkSelf<UnityEngine.MeshCollider>(l);
		pushValue(l,o.convex);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_convex(IntPtr l) {
		UnityEngine.MeshCollider o = checkSelf<UnityEngine.MeshCollider>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.convex=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_smoothSphereCollisions(IntPtr l) {
		UnityEngine.MeshCollider o = checkSelf<UnityEngine.MeshCollider>(l);
		pushValue(l,o.smoothSphereCollisions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_smoothSphereCollisions(IntPtr l) {
		UnityEngine.MeshCollider o = checkSelf<UnityEngine.MeshCollider>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.smoothSphereCollisions=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshCollider");
		addMember(l,get_sharedMesh, "get_sharedMesh");
		addMember(l,set_sharedMesh, "set_sharedMesh");
		addMember(l,get_convex, "get_convex");
		addMember(l,set_convex, "set_convex");
		addMember(l,get_smoothSphereCollisions, "get_smoothSphereCollisions");
		addMember(l,set_smoothSphereCollisions, "set_smoothSphereCollisions");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.MeshCollider),typeof(UnityEngine.Collider));
		LuaDLL.lua_pop(l, 1);
	}
}
