using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Collider2D o;
		o=new UnityEngine.Collider2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OverlapPoint(IntPtr l) {
		try{
			UnityEngine.Collider2D self=(UnityEngine.Collider2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.OverlapPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isTrigger(IntPtr l) {
		UnityEngine.Collider2D o = (UnityEngine.Collider2D)checkSelf(l);
		pushValue(l,o.isTrigger);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isTrigger(IntPtr l) {
		UnityEngine.Collider2D o = (UnityEngine.Collider2D)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isTrigger=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachedRigidbody(IntPtr l) {
		UnityEngine.Collider2D o = (UnityEngine.Collider2D)checkSelf(l);
		pushValue(l,o.attachedRigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shapeCount(IntPtr l) {
		UnityEngine.Collider2D o = (UnityEngine.Collider2D)checkSelf(l);
		pushValue(l,o.shapeCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		UnityEngine.Collider2D o = (UnityEngine.Collider2D)checkSelf(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMaterial(IntPtr l) {
		UnityEngine.Collider2D o = (UnityEngine.Collider2D)checkSelf(l);
		pushValue(l,o.sharedMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMaterial(IntPtr l) {
		UnityEngine.Collider2D o = (UnityEngine.Collider2D)checkSelf(l);
		UnityEngine.PhysicsMaterial2D v;
		checkType(l,2,out v);
		o.sharedMaterial=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collider2D");
		addMember(l,OverlapPoint);
		addMember(l,"isTrigger",get_isTrigger,set_isTrigger,true);
		addMember(l,"attachedRigidbody",get_attachedRigidbody,null,true);
		addMember(l,"shapeCount",get_shapeCount,null,true);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"sharedMaterial",get_sharedMaterial,set_sharedMaterial,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Collider2D),typeof(UnityEngine.Behaviour));
	}
}
