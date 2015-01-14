using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Cloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Cloth o;
		if(matchType(l,1)){
			o=new UnityEngine.Cloth();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bendingStiffness(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.bendingStiffness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bendingStiffness(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.bendingStiffness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stretchingStiffness(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.stretchingStiffness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stretchingStiffness(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.stretchingStiffness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damping(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.damping);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damping(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.damping=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thickness(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.thickness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_thickness(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.thickness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_externalAcceleration(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.externalAcceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_externalAcceleration(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.externalAcceleration=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_randomAcceleration(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.randomAcceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_randomAcceleration(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.randomAcceleration=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGravity(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.useGravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGravity(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useGravity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selfCollision(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.selfCollision);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selfCollision(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.selfCollision=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.vertices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normals(IntPtr l) {
		UnityEngine.Cloth o = checkSelf<UnityEngine.Cloth>(l);
		pushValue(l,o.normals);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Cloth");
		addMember(l,get_bendingStiffness, "get_bendingStiffness");
		addMember(l,set_bendingStiffness, "set_bendingStiffness");
		addMember(l,get_stretchingStiffness, "get_stretchingStiffness");
		addMember(l,set_stretchingStiffness, "set_stretchingStiffness");
		addMember(l,get_damping, "get_damping");
		addMember(l,set_damping, "set_damping");
		addMember(l,get_thickness, "get_thickness");
		addMember(l,set_thickness, "set_thickness");
		addMember(l,get_externalAcceleration, "get_externalAcceleration");
		addMember(l,set_externalAcceleration, "set_externalAcceleration");
		addMember(l,get_randomAcceleration, "get_randomAcceleration");
		addMember(l,set_randomAcceleration, "set_randomAcceleration");
		addMember(l,get_useGravity, "get_useGravity");
		addMember(l,set_useGravity, "set_useGravity");
		addMember(l,get_selfCollision, "get_selfCollision");
		addMember(l,set_selfCollision, "set_selfCollision");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		addMember(l,get_vertices, "get_vertices");
		addMember(l,get_normals, "get_normals");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Cloth),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
