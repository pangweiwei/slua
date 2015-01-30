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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		UnityEngine.OcclusionArea o = (UnityEngine.OcclusionArea)checkSelf(l);
		pushValue(l,o.center);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		UnityEngine.OcclusionArea o = (UnityEngine.OcclusionArea)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.center=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.OcclusionArea o = (UnityEngine.OcclusionArea)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.OcclusionArea o = (UnityEngine.OcclusionArea)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OcclusionArea");
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"size",get_size,set_size,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.OcclusionArea),typeof(UnityEngine.Component));
	}
}
