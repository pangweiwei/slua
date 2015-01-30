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
		if(matchType(l,1,typeof(float),typeof(UnityEngine.Renderer[]))){
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Renderer[] a2;
			checkType(l,2,out a2);
			o=new UnityEngine.LOD(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenRelativeTransitionHeight(IntPtr l) {
		UnityEngine.LOD o = (UnityEngine.LOD)checkSelf(l);
		pushValue(l,o.screenRelativeTransitionHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_screenRelativeTransitionHeight(IntPtr l) {
		UnityEngine.LOD o = (UnityEngine.LOD)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.screenRelativeTransitionHeight=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderers(IntPtr l) {
		UnityEngine.LOD o = (UnityEngine.LOD)checkSelf(l);
		pushValue(l,o.renderers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderers(IntPtr l) {
		UnityEngine.LOD o = (UnityEngine.LOD)checkSelf(l);
		UnityEngine.Renderer[] v;
		checkType(l,2,out v);
		o.renderers=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LOD");
		addMember(l,"screenRelativeTransitionHeight",get_screenRelativeTransitionHeight,set_screenRelativeTransitionHeight,true);
		addMember(l,"renderers",get_renderers,set_renderers,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LOD));
	}
}
