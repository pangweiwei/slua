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
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		pushValue(l,o.direction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		UnityEngine.CapsuleCollider o = (UnityEngine.CapsuleCollider)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.direction=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CapsuleCollider");
		addMember(l,"center",get_center,set_center);
		addMember(l,"radius",get_radius,set_radius);
		addMember(l,"height",get_height,set_height);
		addMember(l,"direction",get_direction,set_direction);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CapsuleCollider),typeof(UnityEngine.Collider));
	}
}
