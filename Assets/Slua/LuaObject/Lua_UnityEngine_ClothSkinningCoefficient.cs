using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ClothSkinningCoefficient : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
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
		addMember(l,"maxDistance",get_maxDistance,set_maxDistance,true);
		addMember(l,"collisionSphereDistance",get_collisionSphereDistance,set_collisionSphereDistance,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ClothSkinningCoefficient));
	}
}
