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
			UnityEngine.RaycastHit2D self=(UnityEngine.RaycastHit2D)checkSelf(l);
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
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.centroid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centroid(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.centroid=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_point(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.point=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.distance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fraction(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.fraction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fraction(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.fraction=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.RaycastHit2D o = (UnityEngine.RaycastHit2D)checkSelf(l);
		pushValue(l,o.transform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RaycastHit2D");
		addMember(l,CompareTo);
		addMember(l,"centroid",get_centroid,set_centroid);
		addMember(l,"point",get_point,set_point);
		addMember(l,"normal",get_normal,set_normal);
		addMember(l,"distance",get_distance,set_distance);
		addMember(l,"fraction",get_fraction,set_fraction);
		addMember(l,"collider",get_collider,null);
		addMember(l,"rigidbody",get_rigidbody,null);
		addMember(l,"transform",get_transform,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RaycastHit2D));
	}
}
