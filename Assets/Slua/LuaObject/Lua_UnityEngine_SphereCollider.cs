using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SphereCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SphereCollider o;
		if(matchType(l,1)){
			o=new UnityEngine.SphereCollider();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.SphereCollider o = checkSelf<UnityEngine.SphereCollider>(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.SphereCollider o = checkSelf<UnityEngine.SphereCollider>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.SphereCollider o = checkSelf<UnityEngine.SphereCollider>(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.SphereCollider o = checkSelf<UnityEngine.SphereCollider>(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SphereCollider");
		addMember(l,get_center, "get_center");
		addMember(l,set_center, "set_center");
		addMember(l,get_radius, "get_radius");
		addMember(l,set_radius, "set_radius");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.SphereCollider),typeof(UnityEngine.Collider));
		LuaDLL.lua_pop(l, 1);
	}
}
