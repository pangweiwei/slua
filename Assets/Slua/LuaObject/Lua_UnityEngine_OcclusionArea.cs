using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OcclusionArea : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.OcclusionArea o;
		if(matchType(l,1)){
			o=new UnityEngine.OcclusionArea();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.OcclusionArea o = checkSelf<UnityEngine.OcclusionArea>(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.OcclusionArea o = checkSelf<UnityEngine.OcclusionArea>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.OcclusionArea o = checkSelf<UnityEngine.OcclusionArea>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.OcclusionArea o = checkSelf<UnityEngine.OcclusionArea>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OcclusionArea");
		addMember(l,get_center, "get_center");
		addMember(l,set_center, "set_center");
		addMember(l,get_size, "get_size");
		addMember(l,set_size, "set_size");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.OcclusionArea),typeof(UnityEngine.Component));
		LuaDLL.lua_pop(l, 1);
	}
}
