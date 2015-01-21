using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CircleCollider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.CircleCollider2D o;
		if(matchType(l,1)){
			o=new UnityEngine.CircleCollider2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.CircleCollider2D o = (UnityEngine.CircleCollider2D)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.CircleCollider2D o = (UnityEngine.CircleCollider2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.CircleCollider2D o = (UnityEngine.CircleCollider2D)checkSelf(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.CircleCollider2D o = (UnityEngine.CircleCollider2D)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CircleCollider2D");
		addMember(l,"center",get_center,set_center);
		addMember(l,"radius",get_radius,set_radius);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CircleCollider2D),typeof(UnityEngine.Collider2D));
	}
}
