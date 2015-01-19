using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Light : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Light o;
		if(matchType(l,1)){
			o=new UnityEngine.Light();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLights(IntPtr l) {
		try{
			UnityEngine.LightType a1;
			checkEnum(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Light[] ret=UnityEngine.Light.GetLights(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		UnityEngine.LightType v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intensity(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.intensity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intensity(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.intensity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadows(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.shadows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadows(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		UnityEngine.LightShadows v;
		checkEnum(l,2,out v);
		o.shadows=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowStrength(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.shadowStrength);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowStrength(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.shadowStrength=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowBias(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.shadowBias);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowBias(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.shadowBias=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowSoftness(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.shadowSoftness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowSoftness(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.shadowSoftness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowSoftnessFade(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.shadowSoftnessFade);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowSoftnessFade(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.shadowSoftnessFade=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_range(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.range);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_range(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.range=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spotAngle(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.spotAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spotAngle(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.spotAngle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cookieSize(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.cookieSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cookieSize(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Single v;
		checkType(l,2,out v);
		o.cookieSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cookie(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.cookie);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cookie(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.cookie=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flare(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.flare);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flare(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		UnityEngine.Flare v;
		checkType(l,2,out v);
		o.flare=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderMode(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.renderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		UnityEngine.LightRenderMode v;
		checkEnum(l,2,out v);
		o.renderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alreadyLightmapped(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.alreadyLightmapped);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alreadyLightmapped(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.alreadyLightmapped=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMask(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		pushValue(l,o.cullingMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMask(IntPtr l) {
		UnityEngine.Light o = checkSelf<UnityEngine.Light>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.cullingMask=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Light");
		addMember(l,GetLights, "GetLights");
		addMember(l,get_type, "get_type");
		addMember(l,set_type, "set_type");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_intensity, "get_intensity");
		addMember(l,set_intensity, "set_intensity");
		addMember(l,get_shadows, "get_shadows");
		addMember(l,set_shadows, "set_shadows");
		addMember(l,get_shadowStrength, "get_shadowStrength");
		addMember(l,set_shadowStrength, "set_shadowStrength");
		addMember(l,get_shadowBias, "get_shadowBias");
		addMember(l,set_shadowBias, "set_shadowBias");
		addMember(l,get_shadowSoftness, "get_shadowSoftness");
		addMember(l,set_shadowSoftness, "set_shadowSoftness");
		addMember(l,get_shadowSoftnessFade, "get_shadowSoftnessFade");
		addMember(l,set_shadowSoftnessFade, "set_shadowSoftnessFade");
		addMember(l,get_range, "get_range");
		addMember(l,set_range, "set_range");
		addMember(l,get_spotAngle, "get_spotAngle");
		addMember(l,set_spotAngle, "set_spotAngle");
		addMember(l,get_cookieSize, "get_cookieSize");
		addMember(l,set_cookieSize, "set_cookieSize");
		addMember(l,get_cookie, "get_cookie");
		addMember(l,set_cookie, "set_cookie");
		addMember(l,get_flare, "get_flare");
		addMember(l,set_flare, "set_flare");
		addMember(l,get_renderMode, "get_renderMode");
		addMember(l,set_renderMode, "set_renderMode");
		addMember(l,get_alreadyLightmapped, "get_alreadyLightmapped");
		addMember(l,set_alreadyLightmapped, "set_alreadyLightmapped");
		addMember(l,get_cullingMask, "get_cullingMask");
		addMember(l,set_cullingMask, "set_cullingMask");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Light),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
