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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_controller(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.controller);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collider(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.collider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rigidbody(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.rigidbody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transform(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.transform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_moveDirection(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.moveDirection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_moveLength(IntPtr l) {
		UnityEngine.ControllerColliderHit o = (UnityEngine.ControllerColliderHit)checkSelf(l);
		pushValue(l,o.moveLength);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ControllerColliderHit");
		addMember(l,"controller",get_controller,null);
		addMember(l,"collider",get_collider,null);
		addMember(l,"rigidbody",get_rigidbody,null);
		addMember(l,"gameObject",get_gameObject,null);
		addMember(l,"transform",get_transform,null);
		addMember(l,"point",get_point,null);
		addMember(l,"normal",get_normal,null);
		addMember(l,"moveDirection",get_moveDirection,null);
		addMember(l,"moveLength",get_moveLength,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ControllerColliderHit));
	}
}
