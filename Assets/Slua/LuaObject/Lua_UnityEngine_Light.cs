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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLights_s(IntPtr l) {
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
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushEnum(l,(int)o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		UnityEngine.LightType v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intensity(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.intensity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intensity(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.intensity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadows(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushEnum(l,(int)o.shadows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadows(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		UnityEngine.LightShadows v;
		checkEnum(l,2,out v);
		o.shadows=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowStrength(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.shadowStrength);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowStrength(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.shadowStrength=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowBias(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.shadowBias);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowBias(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.shadowBias=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowSoftness(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.shadowSoftness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowSoftness(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.shadowSoftness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowSoftnessFade(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.shadowSoftnessFade);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowSoftnessFade(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.shadowSoftnessFade=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_range(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.range);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_range(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.range=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spotAngle(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.spotAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spotAngle(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.spotAngle=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cookieSize(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.cookieSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cookieSize(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.cookieSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cookie(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.cookie);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cookie(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		UnityEngine.Texture v;
		checkType(l,2,out v);
		o.cookie=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flare(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.flare);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flare(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		UnityEngine.Flare v;
		checkType(l,2,out v);
		o.flare=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderMode(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushEnum(l,(int)o.renderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		UnityEngine.LightRenderMode v;
		checkEnum(l,2,out v);
		o.renderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alreadyLightmapped(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.alreadyLightmapped);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alreadyLightmapped(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.alreadyLightmapped=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMask(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		pushValue(l,o.cullingMask);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMask(IntPtr l) {
		UnityEngine.Light o = (UnityEngine.Light)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.cullingMask=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Light");
		addMember(l,GetLights_s);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"intensity",get_intensity,set_intensity,true);
		addMember(l,"shadows",get_shadows,set_shadows,true);
		addMember(l,"shadowStrength",get_shadowStrength,set_shadowStrength,true);
		addMember(l,"shadowBias",get_shadowBias,set_shadowBias,true);
		addMember(l,"shadowSoftness",get_shadowSoftness,set_shadowSoftness,true);
		addMember(l,"shadowSoftnessFade",get_shadowSoftnessFade,set_shadowSoftnessFade,true);
		addMember(l,"range",get_range,set_range,true);
		addMember(l,"spotAngle",get_spotAngle,set_spotAngle,true);
		addMember(l,"cookieSize",get_cookieSize,set_cookieSize,true);
		addMember(l,"cookie",get_cookie,set_cookie,true);
		addMember(l,"flare",get_flare,set_flare,true);
		addMember(l,"renderMode",get_renderMode,set_renderMode,true);
		addMember(l,"alreadyLightmapped",get_alreadyLightmapped,set_alreadyLightmapped,true);
		addMember(l,"cullingMask",get_cullingMask,set_cullingMask,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Light),typeof(UnityEngine.Behaviour));
	}
}
