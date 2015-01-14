using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RaycastHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_point(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.point=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_barycentricCoordinate(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.barycentricCoordinate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_barycentricCoordinate(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.barycentricCoordinate=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		System.Single v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_triangleIndex(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.triangleIndex);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureCoord(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.textureCoord);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureCoord2(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.textureCoord2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapCoord(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.lightmapCoord);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.RaycastHit o = checkSelf<UnityEngine.RaycastHit>(l);
		pushValue(l,o.transform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RaycastHit");
		addMember(l,get_point, "get_point");
		addMember(l,set_point, "set_point");
		addMember(l,get_normal, "get_normal");
		addMember(l,set_normal, "set_normal");
		addMember(l,get_barycentricCoordinate, "get_barycentricCoordinate");
		addMember(l,set_barycentricCoordinate, "set_barycentricCoordinate");
		addMember(l,get_distance, "get_distance");
		addMember(l,set_distance, "set_distance");
		addMember(l,get_triangleIndex, "get_triangleIndex");
		addMember(l,get_textureCoord, "get_textureCoord");
		addMember(l,get_textureCoord2, "get_textureCoord2");
		addMember(l,get_lightmapCoord, "get_lightmapCoord");
		addMember(l,get_collider, "get_collider");
		addMember(l,get_rigidbody, "get_rigidbody");
		addMember(l,get_transform, "get_transform");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.RaycastHit));
		LuaDLL.lua_pop(l, 1);
	}
}
