using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CapsuleCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.CapsuleCollider o;
		if(matchType(l,1)){
			o=new UnityEngine.CapsuleCollider();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		System.Single v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		pushValue(l,o.direction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		UnityEngine.CapsuleCollider o = checkSelf<UnityEngine.CapsuleCollider>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.direction=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CapsuleCollider");
		addMember(l,get_center, "get_center");
		addMember(l,set_center, "set_center");
		addMember(l,get_radius, "get_radius");
		addMember(l,set_radius, "set_radius");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_direction, "get_direction");
		addMember(l,set_direction, "set_direction");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.CapsuleCollider),typeof(UnityEngine.Collider));
		LuaDLL.lua_pop(l, 1);
	}
}
