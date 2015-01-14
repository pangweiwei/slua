using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ControllerColliderHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ControllerColliderHit o;
		if(matchType(l,1)){
			o=new UnityEngine.ControllerColliderHit();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_controller(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.controller);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_moveDirection(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.moveDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_moveLength(IntPtr l) {
		UnityEngine.ControllerColliderHit o = checkSelf<UnityEngine.ControllerColliderHit>(l);
		pushValue(l,o.moveLength);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ControllerColliderHit");
		addMember(l,get_controller, "get_controller");
		addMember(l,get_collider, "get_collider");
		addMember(l,get_rigidbody, "get_rigidbody");
		addMember(l,get_gameObject, "get_gameObject");
		addMember(l,get_transform, "get_transform");
		addMember(l,get_point, "get_point");
		addMember(l,get_normal, "get_normal");
		addMember(l,get_moveDirection, "get_moveDirection");
		addMember(l,get_moveLength, "get_moveLength");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ControllerColliderHit));
		LuaDLL.lua_pop(l, 1);
	}
}
