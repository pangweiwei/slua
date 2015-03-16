using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ClothSphereColliderPair : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.ClothSphereColliderPair o;
		if(argc==2){
			UnityEngine.SphereCollider a1;
			checkType(l,2,out a1);
			o=new UnityEngine.ClothSphereColliderPair(a1);
			pushObject(l,o);
			return 1;
		}
		else if(argc==3){
			UnityEngine.SphereCollider a1;
			checkType(l,2,out a1);
			UnityEngine.SphereCollider a2;
			checkType(l,3,out a2);
			o=new UnityEngine.ClothSphereColliderPair(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_first(IntPtr l) {
		UnityEngine.ClothSphereColliderPair o = (UnityEngine.ClothSphereColliderPair)checkSelf(l);
		pushValue(l,o.first);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_first(IntPtr l) {
		UnityEngine.ClothSphereColliderPair o = (UnityEngine.ClothSphereColliderPair)checkSelf(l);
		UnityEngine.SphereCollider v;
		checkType(l,2,out v);
		o.first=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_second(IntPtr l) {
		UnityEngine.ClothSphereColliderPair o = (UnityEngine.ClothSphereColliderPair)checkSelf(l);
		pushValue(l,o.second);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_second(IntPtr l) {
		UnityEngine.ClothSphereColliderPair o = (UnityEngine.ClothSphereColliderPair)checkSelf(l);
		UnityEngine.SphereCollider v;
		checkType(l,2,out v);
		o.second=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ClothSphereColliderPair");
		addMember(l,"first",get_first,set_first,true);
		addMember(l,"second",get_second,set_second,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ClothSphereColliderPair));
	}
}
