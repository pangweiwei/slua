using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightmapData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.LightmapData o;
		if(matchType(l,1)){
			o=new UnityEngine.LightmapData();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapFar(IntPtr l) {
		UnityEngine.LightmapData o = checkSelf<UnityEngine.LightmapData>(l);
		pushValue(l,o.lightmapFar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapFar(IntPtr l) {
		UnityEngine.LightmapData o = checkSelf<UnityEngine.LightmapData>(l);
		UnityEngine.Texture2D v;
		checkType(l,2,out v);
		o.lightmapFar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapNear(IntPtr l) {
		UnityEngine.LightmapData o = checkSelf<UnityEngine.LightmapData>(l);
		pushValue(l,o.lightmapNear);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapNear(IntPtr l) {
		UnityEngine.LightmapData o = checkSelf<UnityEngine.LightmapData>(l);
		UnityEngine.Texture2D v;
		checkType(l,2,out v);
		o.lightmapNear=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightmapData");
		addMember(l,get_lightmapFar, "get_lightmapFar");
		addMember(l,set_lightmapFar, "set_lightmapFar");
		addMember(l,get_lightmapNear, "get_lightmapNear");
		addMember(l,set_lightmapNear, "set_lightmapNear");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LightmapData));
		LuaDLL.lua_pop(l, 1);
	}
}
