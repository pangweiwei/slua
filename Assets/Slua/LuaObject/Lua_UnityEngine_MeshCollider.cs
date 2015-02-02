using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.MeshCollider o;
		o=new UnityEngine.MeshCollider();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMesh(IntPtr l) {
		UnityEngine.MeshCollider o = (UnityEngine.MeshCollider)checkSelf(l);
		pushValue(l,o.sharedMesh);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMesh(IntPtr l) {
		UnityEngine.MeshCollider o = (UnityEngine.MeshCollider)checkSelf(l);
		UnityEngine.Mesh v;
		checkType(l,2,out v);
		o.sharedMesh=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_convex(IntPtr l) {
		UnityEngine.MeshCollider o = (UnityEngine.MeshCollider)checkSelf(l);
		pushValue(l,o.convex);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_convex(IntPtr l) {
		UnityEngine.MeshCollider o = (UnityEngine.MeshCollider)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.convex=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_smoothSphereCollisions(IntPtr l) {
		UnityEngine.MeshCollider o = (UnityEngine.MeshCollider)checkSelf(l);
		pushValue(l,o.smoothSphereCollisions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_smoothSphereCollisions(IntPtr l) {
		UnityEngine.MeshCollider o = (UnityEngine.MeshCollider)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.smoothSphereCollisions=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshCollider");
		addMember(l,"sharedMesh",get_sharedMesh,set_sharedMesh,true);
		addMember(l,"convex",get_convex,set_convex,true);
		addMember(l,"smoothSphereCollisions",get_smoothSphereCollisions,set_smoothSphereCollisions,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.MeshCollider),typeof(UnityEngine.Collider));
	}
}
