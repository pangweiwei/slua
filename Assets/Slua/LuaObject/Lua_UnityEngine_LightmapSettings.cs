using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightmapSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.LightmapSettings o;
		if(matchType(l,1)){
			o=new UnityEngine.LightmapSettings();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmaps(IntPtr l) {
		pushValue(l,UnityEngine.LightmapSettings.lightmaps);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmaps(IntPtr l) {
		UnityEngine.LightmapData[] v;
		checkType(l,2,out v);
		UnityEngine.LightmapSettings.lightmaps=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapsMode(IntPtr l) {
		pushValue(l,UnityEngine.LightmapSettings.lightmapsMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapsMode(IntPtr l) {
		UnityEngine.LightmapsMode v;
		checkEnum(l,2,out v);
		UnityEngine.LightmapSettings.lightmapsMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bakedColorSpace(IntPtr l) {
		pushValue(l,UnityEngine.LightmapSettings.bakedColorSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bakedColorSpace(IntPtr l) {
		UnityEngine.ColorSpace v;
		checkEnum(l,2,out v);
		UnityEngine.LightmapSettings.bakedColorSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightProbes(IntPtr l) {
		pushValue(l,UnityEngine.LightmapSettings.lightProbes);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightProbes(IntPtr l) {
		UnityEngine.LightProbes v;
		checkType(l,2,out v);
		UnityEngine.LightmapSettings.lightProbes=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightmapSettings");
		addMember(l,get_lightmaps, "get_lightmaps");
		addMember(l,set_lightmaps, "set_lightmaps");
		addMember(l,get_lightmapsMode, "get_lightmapsMode");
		addMember(l,set_lightmapsMode, "set_lightmapsMode");
		addMember(l,get_bakedColorSpace, "get_bakedColorSpace");
		addMember(l,set_bakedColorSpace, "set_bakedColorSpace");
		addMember(l,get_lightProbes, "get_lightProbes");
		addMember(l,set_lightProbes, "set_lightProbes");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LightmapSettings),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
