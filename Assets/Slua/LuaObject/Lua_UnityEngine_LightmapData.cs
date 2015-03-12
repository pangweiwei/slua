﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightmapData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.LightmapData o;
		o=new UnityEngine.LightmapData();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapFar(IntPtr l) {
		UnityEngine.LightmapData o = (UnityEngine.LightmapData)checkSelf(l);
		pushValue(l,o.lightmapFar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapFar(IntPtr l) {
		UnityEngine.LightmapData o = (UnityEngine.LightmapData)checkSelf(l);
		UnityEngine.Texture2D v;
		checkType(l,2,out v);
		o.lightmapFar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapNear(IntPtr l) {
		UnityEngine.LightmapData o = (UnityEngine.LightmapData)checkSelf(l);
		pushValue(l,o.lightmapNear);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapNear(IntPtr l) {
		UnityEngine.LightmapData o = (UnityEngine.LightmapData)checkSelf(l);
		UnityEngine.Texture2D v;
		checkType(l,2,out v);
		o.lightmapNear=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightmapData");
		addMember(l,"lightmapFar",get_lightmapFar,set_lightmapFar,true);
		addMember(l,"lightmapNear",get_lightmapNear,set_lightmapNear,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightmapData));
	}
}
