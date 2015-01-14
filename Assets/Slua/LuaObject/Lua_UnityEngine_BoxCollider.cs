using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BoxCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.BoxCollider o;
		if(matchType(l,1)){
			o=new UnityEngine.BoxCollider();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.BoxCollider o = checkSelf<UnityEngine.BoxCollider>(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.BoxCollider o = checkSelf<UnityEngine.BoxCollider>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.BoxCollider o = checkSelf<UnityEngine.BoxCollider>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.BoxCollider o = checkSelf<UnityEngine.BoxCollider>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BoxCollider");
		addMember(l,get_center, "get_center");
		addMember(l,set_center, "set_center");
		addMember(l,get_size, "get_size");
		addMember(l,set_size, "set_size");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.BoxCollider),typeof(UnityEngine.Collider));
		LuaDLL.lua_pop(l, 1);
	}
}
