using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ContactPoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		UnityEngine.ContactPoint o = (UnityEngine.ContactPoint)checkSelf(l);
		pushValue(l,o.point);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.ContactPoint o = (UnityEngine.ContactPoint)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thisCollider(IntPtr l) {
		UnityEngine.ContactPoint o = (UnityEngine.ContactPoint)checkSelf(l);
		pushValue(l,o.thisCollider);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_otherCollider(IntPtr l) {
		UnityEngine.ContactPoint o = (UnityEngine.ContactPoint)checkSelf(l);
		pushValue(l,o.otherCollider);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ContactPoint");
		addMember(l,"point",get_point,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"thisCollider",get_thisCollider,null,true);
		addMember(l,"otherCollider",get_otherCollider,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ContactPoint));
	}
}
