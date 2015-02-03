using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collision2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Collision2D o;
		o=new UnityEngine.Collision2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.Collision2D o = (UnityEngine.Collision2D)checkSelf(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.Collision2D o = (UnityEngine.Collision2D)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.Collision2D o = (UnityEngine.Collision2D)checkSelf(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.Collision2D o = (UnityEngine.Collision2D)checkSelf(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contacts(IntPtr l) {
		UnityEngine.Collision2D o = (UnityEngine.Collision2D)checkSelf(l);
		pushValue(l,o.contacts);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeVelocity(IntPtr l) {
		UnityEngine.Collision2D o = (UnityEngine.Collision2D)checkSelf(l);
		pushValue(l,o.relativeVelocity);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collision2D");
		addMember(l,"rigidbody",get_rigidbody,null,true);
		addMember(l,"collider",get_collider,null,true);
		addMember(l,"transform",get_transform,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		addMember(l,"contacts",get_contacts,null,true);
		addMember(l,"relativeVelocity",get_relativeVelocity,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Collision2D));
	}
}
