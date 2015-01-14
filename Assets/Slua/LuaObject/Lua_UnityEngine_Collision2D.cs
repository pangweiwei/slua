using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collision2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Collision2D o;
		if(matchType(l,1)){
			o=new UnityEngine.Collision2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.Collision2D o = checkSelf<UnityEngine.Collision2D>(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.Collision2D o = checkSelf<UnityEngine.Collision2D>(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.Collision2D o = checkSelf<UnityEngine.Collision2D>(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.Collision2D o = checkSelf<UnityEngine.Collision2D>(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contacts(IntPtr l) {
		UnityEngine.Collision2D o = checkSelf<UnityEngine.Collision2D>(l);
		pushValue(l,o.contacts);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeVelocity(IntPtr l) {
		UnityEngine.Collision2D o = checkSelf<UnityEngine.Collision2D>(l);
		pushValue(l,o.relativeVelocity);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collision2D");
		addMember(l,get_rigidbody, "get_rigidbody");
		addMember(l,get_collider, "get_collider");
		addMember(l,get_transform, "get_transform");
		addMember(l,get_gameObject, "get_gameObject");
		addMember(l,get_contacts, "get_contacts");
		addMember(l,get_relativeVelocity, "get_relativeVelocity");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Collision2D));
		LuaDLL.lua_pop(l, 1);
	}
}
