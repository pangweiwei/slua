using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RaycastHit2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompareTo(IntPtr l) {
		try{
			UnityEngine.RaycastHit2D self=checkSelf<UnityEngine.RaycastHit2D>(l);
			UnityEngine.RaycastHit2D a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.CompareTo(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centroid(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.centroid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centroid(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.centroid=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_point(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.point=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fraction(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.fraction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fraction(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.fraction=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.RaycastHit2D o = checkSelf<UnityEngine.RaycastHit2D>(l);
		pushValue(l,o.transform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RaycastHit2D");
		addMember(l,CompareTo, "CompareTo");
		addMember(l,get_centroid, "get_centroid");
		addMember(l,set_centroid, "set_centroid");
		addMember(l,get_point, "get_point");
		addMember(l,set_point, "set_point");
		addMember(l,get_normal, "get_normal");
		addMember(l,set_normal, "set_normal");
		addMember(l,get_distance, "get_distance");
		addMember(l,set_distance, "set_distance");
		addMember(l,get_fraction, "get_fraction");
		addMember(l,set_fraction, "set_fraction");
		addMember(l,get_collider, "get_collider");
		addMember(l,get_rigidbody, "get_rigidbody");
		addMember(l,get_transform, "get_transform");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.RaycastHit2D));
		LuaDLL.lua_pop(l, 1);
	}
}
