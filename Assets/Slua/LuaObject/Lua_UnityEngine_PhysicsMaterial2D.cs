using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PhysicsMaterial2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.PhysicsMaterial2D o;
		if(matchType(l,1)){
			o=new UnityEngine.PhysicsMaterial2D();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.PhysicsMaterial2D(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounciness(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = checkSelf<UnityEngine.PhysicsMaterial2D>(l);
		pushValue(l,o.bounciness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounciness(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = checkSelf<UnityEngine.PhysicsMaterial2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.bounciness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_friction(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = checkSelf<UnityEngine.PhysicsMaterial2D>(l);
		pushValue(l,o.friction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_friction(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = checkSelf<UnityEngine.PhysicsMaterial2D>(l);
		System.Single v;
		checkType(l,2,out v);
		o.friction=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PhysicsMaterial2D");
		addMember(l,get_bounciness, "get_bounciness");
		addMember(l,set_bounciness, "set_bounciness");
		addMember(l,get_friction, "get_friction");
		addMember(l,set_friction, "set_friction");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.PhysicsMaterial2D),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
