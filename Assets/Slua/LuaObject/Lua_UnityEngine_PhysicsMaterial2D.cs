using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PhysicsMaterial2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.PhysicsMaterial2D o;
		if(argc==1){
			o=new UnityEngine.PhysicsMaterial2D();
			pushObject(l,o);
			return 1;
		}
		else if(argc==2){
			System.String a1;
			checkType(l,2,out a1);
			o=new UnityEngine.PhysicsMaterial2D(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounciness(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = (UnityEngine.PhysicsMaterial2D)checkSelf(l);
		pushValue(l,o.bounciness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounciness(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = (UnityEngine.PhysicsMaterial2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.bounciness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_friction(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = (UnityEngine.PhysicsMaterial2D)checkSelf(l);
		pushValue(l,o.friction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_friction(IntPtr l) {
		UnityEngine.PhysicsMaterial2D o = (UnityEngine.PhysicsMaterial2D)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.friction=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PhysicsMaterial2D");
		addMember(l,"bounciness",get_bounciness,set_bounciness,true);
		addMember(l,"friction",get_friction,set_friction,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PhysicsMaterial2D),typeof(UnityEngine.Object));
	}
}
