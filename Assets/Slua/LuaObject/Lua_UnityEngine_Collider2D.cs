using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Collider2D o;
		if(matchType(l,1)){
			o=new UnityEngine.Collider2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapPoint(IntPtr l) {
		try{
			UnityEngine.Collider2D self=checkSelf<UnityEngine.Collider2D>(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.OverlapPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTrigger(IntPtr l) {
		UnityEngine.Collider2D o = checkSelf<UnityEngine.Collider2D>(l);
		pushValue(l,o.isTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isTrigger(IntPtr l) {
		UnityEngine.Collider2D o = checkSelf<UnityEngine.Collider2D>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachedRigidbody(IntPtr l) {
		UnityEngine.Collider2D o = checkSelf<UnityEngine.Collider2D>(l);
		pushValue(l,o.attachedRigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shapeCount(IntPtr l) {
		UnityEngine.Collider2D o = checkSelf<UnityEngine.Collider2D>(l);
		pushValue(l,o.shapeCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.Collider2D o = checkSelf<UnityEngine.Collider2D>(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterial(IntPtr l) {
		UnityEngine.Collider2D o = checkSelf<UnityEngine.Collider2D>(l);
		pushValue(l,o.sharedMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterial(IntPtr l) {
		UnityEngine.Collider2D o = checkSelf<UnityEngine.Collider2D>(l);
		UnityEngine.PhysicsMaterial2D v;
		checkType(l,2,out v);
		o.sharedMaterial=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collider2D");
		addMember(l,OverlapPoint, "OverlapPoint");
		addMember(l,get_isTrigger, "get_isTrigger");
		addMember(l,set_isTrigger, "set_isTrigger");
		addMember(l,get_attachedRigidbody, "get_attachedRigidbody");
		addMember(l,get_shapeCount, "get_shapeCount");
		addMember(l,get_bounds, "get_bounds");
		addMember(l,get_sharedMaterial, "get_sharedMaterial");
		addMember(l,set_sharedMaterial, "set_sharedMaterial");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Collider2D),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
