using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PhysicMaterial : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.PhysicMaterial o;
		if(matchType(l,1)){
			o=new UnityEngine.PhysicMaterial();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.PhysicMaterial(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFriction(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.dynamicFriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFriction(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.dynamicFriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_staticFriction(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.staticFriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_staticFriction(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.staticFriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounciness(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.bounciness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounciness(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.bounciness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frictionDirection2(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.frictionDirection2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frictionDirection2(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.frictionDirection2=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicFriction2(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.dynamicFriction2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicFriction2(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.dynamicFriction2=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_staticFriction2(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.staticFriction2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_staticFriction2(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.staticFriction2=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frictionCombine(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.frictionCombine);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frictionCombine(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		UnityEngine.PhysicMaterialCombine v;
		checkEnum(l,2,out v);
		o.frictionCombine=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounceCombine(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		pushValue(l,o.bounceCombine);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounceCombine(IntPtr l) {
		UnityEngine.PhysicMaterial o = (UnityEngine.PhysicMaterial)checkSelf(l);
		UnityEngine.PhysicMaterialCombine v;
		checkEnum(l,2,out v);
		o.bounceCombine=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PhysicMaterial");
		addMember(l,"dynamicFriction",get_dynamicFriction,set_dynamicFriction);
		addMember(l,"staticFriction",get_staticFriction,set_staticFriction);
		addMember(l,"bounciness",get_bounciness,set_bounciness);
		addMember(l,"frictionDirection2",get_frictionDirection2,set_frictionDirection2);
		addMember(l,"dynamicFriction2",get_dynamicFriction2,set_dynamicFriction2);
		addMember(l,"staticFriction2",get_staticFriction2,set_staticFriction2);
		addMember(l,"frictionCombine",get_frictionCombine,set_frictionCombine);
		addMember(l,"bounceCombine",get_bounceCombine,set_bounceCombine);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PhysicMaterial),typeof(UnityEngine.Object));
	}
}
