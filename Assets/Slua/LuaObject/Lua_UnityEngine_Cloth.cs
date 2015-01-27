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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bendingStiffness(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.bendingStiffness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bendingStiffness(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.bendingStiffness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stretchingStiffness(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.stretchingStiffness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stretchingStiffness(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.stretchingStiffness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damping(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.damping);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damping(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.damping=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thickness(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.thickness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_thickness(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.thickness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_externalAcceleration(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.externalAcceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_externalAcceleration(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.externalAcceleration=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_randomAcceleration(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.randomAcceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_randomAcceleration(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.randomAcceleration=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGravity(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.useGravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGravity(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useGravity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selfCollision(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.selfCollision);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selfCollision(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.selfCollision=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.vertices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normals(IntPtr l) {
		UnityEngine.Cloth o = (UnityEngine.Cloth)checkSelf(l);
		pushValue(l,o.normals);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Cloth");
		addMember(l,"bendingStiffness",get_bendingStiffness,set_bendingStiffness,true);
		addMember(l,"stretchingStiffness",get_stretchingStiffness,set_stretchingStiffness,true);
		addMember(l,"damping",get_damping,set_damping,true);
		addMember(l,"thickness",get_thickness,set_thickness,true);
		addMember(l,"externalAcceleration",get_externalAcceleration,set_externalAcceleration,true);
		addMember(l,"randomAcceleration",get_randomAcceleration,set_randomAcceleration,true);
		addMember(l,"useGravity",get_useGravity,set_useGravity,true);
		addMember(l,"selfCollision",get_selfCollision,set_selfCollision,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"vertices",get_vertices,null,true);
		addMember(l,"normals",get_normals,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Cloth),typeof(UnityEngine.Component));
	}
}
