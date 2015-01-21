using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ClothSkinningCoefficient : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistance(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		pushValue(l,o.maxDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistance(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxDistance=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistanceBias(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		pushValue(l,o.maxDistanceBias);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistanceBias(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxDistanceBias=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionSphereRadius(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		pushValue(l,o.collisionSphereRadius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionSphereRadius(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.collisionSphereRadius=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionSphereDistance(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		pushValue(l,o.collisionSphereDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionSphereDistance(IntPtr l) {
		UnityEngine.ClothSkinningCoefficient o = (UnityEngine.ClothSkinningCoefficient)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.collisionSphereDistance=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ClothSkinningCoefficient");
		addMember(l,"maxDistance",get_maxDistance,set_maxDistance);
		addMember(l,"maxDistanceBias",get_maxDistanceBias,set_maxDistanceBias);
		addMember(l,"collisionSphereRadius",get_collisionSphereRadius,set_collisionSphereRadius);
		addMember(l,"collisionSphereDistance",get_collisionSphereDistance,set_collisionSphereDistance);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ClothSkinningCoefficient));
	}
}
