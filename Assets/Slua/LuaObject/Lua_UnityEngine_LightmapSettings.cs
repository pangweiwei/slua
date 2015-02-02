using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightmapSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.LightmapSettings o;
		o=new UnityEngine.LightmapSettings();
		pushObject(l,o);
		return 1;
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
		pushEnum(l,(int)UnityEngine.LightmapSettings.lightmapsMode);
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
		pushEnum(l,(int)UnityEngine.LightmapSettings.bakedColorSpace);
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
		addMember(l,"lightmaps",get_lightmaps,set_lightmaps,false);
		addMember(l,"lightmapsMode",get_lightmapsMode,set_lightmapsMode,false);
		addMember(l,"bakedColorSpace",get_bakedColorSpace,set_bakedColorSpace,false);
		addMember(l,"lightProbes",get_lightProbes,set_lightProbes,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightmapSettings),typeof(UnityEngine.Object));
	}
}
