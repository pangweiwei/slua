using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Collider o;
		if(matchType(l,1)){
			o=new UnityEngine.Collider();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClosestPointOnBounds(IntPtr l) {
		try{
			UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 ret=self.ClosestPointOnBounds(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.Collider self=(UnityEngine.Collider)checkSelf(l);
			UnityEngine.Ray a1;
			checkType(l,2,out a1);
			UnityEngine.RaycastHit a2;
			System.Single a3;
			checkType(l,4,out a3);
			System.Boolean ret=self.Raycast(a1,out a2,a3);
			pushValue(l,ret);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachedRigidbody(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		pushValue(l,o.attachedRigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTrigger(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		pushValue(l,o.isTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isTrigger(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		UnityEngine.PhysicMaterial v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterial(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		pushValue(l,o.sharedMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterial(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		UnityEngine.PhysicMaterial v;
		checkType(l,2,out v);
		o.sharedMaterial=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.Collider o = (UnityEngine.Collider)checkSelf(l);
		pushValue(l,o.bounds);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collider");
		addMember(l,ClosestPointOnBounds);
		addMember(l,Raycast);
		addMember(l,"enabled",get_enabled,set_enabled);
		addMember(l,"attachedRigidbody",get_attachedRigidbody,null);
		addMember(l,"isTrigger",get_isTrigger,set_isTrigger);
		addMember(l,"material",get_material,set_material);
		addMember(l,"sharedMaterial",get_sharedMaterial,set_sharedMaterial);
		addMember(l,"bounds",get_bounds,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Collider),typeof(UnityEngine.Component));
	}
}
