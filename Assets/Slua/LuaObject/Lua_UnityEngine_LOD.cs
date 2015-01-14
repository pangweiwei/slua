using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LOD : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.LOD o;
		if(matchType(l,1,typeof(System.Single),typeof(UnityEngine.Renderer))){
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Renderer[] a2;
			checkType(l,2,out a2);
			o=new UnityEngine.LOD(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenRelativeTransitionHeight(IntPtr l) {
		UnityEngine.LOD o = checkSelf<UnityEngine.LOD>(l);
		pushValue(l,o.screenRelativeTransitionHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_screenRelativeTransitionHeight(IntPtr l) {
		UnityEngine.LOD o = checkSelf<UnityEngine.LOD>(l);
		System.Single v;
		checkType(l,2,out v);
		o.screenRelativeTransitionHeight=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderers(IntPtr l) {
		UnityEngine.LOD o = checkSelf<UnityEngine.LOD>(l);
		pushValue(l,o.renderers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderers(IntPtr l) {
		UnityEngine.LOD o = checkSelf<UnityEngine.LOD>(l);
		UnityEngine.Renderer[] v;
		checkType(l,2,out v);
		o.renderers=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LOD");
		addMember(l,get_screenRelativeTransitionHeight, "get_screenRelativeTransitionHeight");
		addMember(l,set_screenRelativeTransitionHeight, "set_screenRelativeTransitionHeight");
		addMember(l,get_renderers, "get_renderers");
		addMember(l,set_renderers, "set_renderers");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LOD));
		LuaDLL.lua_pop(l, 1);
	}
}
