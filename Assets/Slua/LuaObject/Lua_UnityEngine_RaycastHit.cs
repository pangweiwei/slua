using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RaycastHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_point(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.point=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_barycentricCoordinate(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.barycentricCoordinate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_barycentricCoordinate(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.barycentricCoordinate=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_triangleIndex(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.triangleIndex);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureCoord(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.textureCoord);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureCoord2(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.textureCoord2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapCoord(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.lightmapCoord);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.RaycastHit o = (UnityEngine.RaycastHit)checkSelf(l);
		pushValue(l,o.transform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RaycastHit");
		addMember(l,"point",get_point,set_point);
		addMember(l,"normal",get_normal,set_normal);
		addMember(l,"barycentricCoordinate",get_barycentricCoordinate,set_barycentricCoordinate);
		addMember(l,"distance",get_distance,set_distance);
		addMember(l,"triangleIndex",get_triangleIndex,null);
		addMember(l,"textureCoord",get_textureCoord,null);
		addMember(l,"textureCoord2",get_textureCoord2,null);
		addMember(l,"lightmapCoord",get_lightmapCoord,null);
		addMember(l,"collider",get_collider,null);
		addMember(l,"rigidbody",get_rigidbody,null);
		addMember(l,"transform",get_transform,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RaycastHit));
	}
}
