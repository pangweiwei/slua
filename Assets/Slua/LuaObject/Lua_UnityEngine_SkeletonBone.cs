using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SkeletonBone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.name=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		pushValue(l,o.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		UnityEngine.Quaternion v;
		checkType(l,2,out v);
		o.rotation=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scale(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		pushValue(l,o.scale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scale(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.scale=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transformModified(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		pushValue(l,o.transformModified);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_transformModified(IntPtr l) {
		UnityEngine.SkeletonBone o = (UnityEngine.SkeletonBone)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.transformModified=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SkeletonBone");
		addMember(l,"name",get_name,set_name);
		addMember(l,"position",get_position,set_position);
		addMember(l,"rotation",get_rotation,set_rotation);
		addMember(l,"scale",get_scale,set_scale);
		addMember(l,"transformModified",get_transformModified,set_transformModified);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SkeletonBone));
	}
}
