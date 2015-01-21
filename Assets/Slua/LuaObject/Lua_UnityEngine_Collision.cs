using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Collision : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Collision o;
		if(matchType(l,1)){
			o=new UnityEngine.Collision();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeVelocity(IntPtr l) {
		UnityEngine.Collision o = (UnityEngine.Collision)checkSelf(l);
		pushValue(l,o.relativeVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.Collision o = (UnityEngine.Collision)checkSelf(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.Collision o = (UnityEngine.Collision)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.Collision o = (UnityEngine.Collision)checkSelf(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.Collision o = (UnityEngine.Collision)checkSelf(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contacts(IntPtr l) {
		UnityEngine.Collision o = (UnityEngine.Collision)checkSelf(l);
		pushValue(l,o.contacts);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Collision");
		addMember(l,"relativeVelocity",get_relativeVelocity,null);
		addMember(l,"rigidbody",get_rigidbody,null);
		addMember(l,"collider",get_collider,null);
		addMember(l,"transform",get_transform,null);
		addMember(l,"gameObject",get_gameObject,null);
		addMember(l,"contacts",get_contacts,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Collision));
	}
}
