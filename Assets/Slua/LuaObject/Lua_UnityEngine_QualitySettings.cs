using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_QualitySettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.QualitySettings o;
		if(matchType(l,1)){
			o=new UnityEngine.QualitySettings();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetQualityLevel(IntPtr l) {
		try{
			System.Int32 ret=UnityEngine.QualitySettings.GetQualityLevel();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetQualityLevel(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32),typeof(System.Boolean))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.QualitySettings.SetQualityLevel(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.QualitySettings.SetQualityLevel(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IncreaseLevel(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Boolean))){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.QualitySettings.IncreaseLevel(a1);
				return 0;
			}
			else if(matchType(l,1)){
				UnityEngine.QualitySettings.IncreaseLevel();
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DecreaseLevel(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Boolean))){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.QualitySettings.DecreaseLevel(a1);
				return 0;
			}
			else if(matchType(l,1)){
				UnityEngine.QualitySettings.DecreaseLevel();
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_names(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.names);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelLightCount(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.pixelLightCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelLightCount(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.pixelLightCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowProjection(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.shadowProjection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowProjection(IntPtr l) {
		UnityEngine.ShadowProjection v;
		checkEnum(l,2,out v);
		UnityEngine.QualitySettings.shadowProjection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowCascades(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.shadowCascades);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowCascades(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.shadowCascades=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowDistance(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.shadowDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowDistance(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.shadowDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_masterTextureLimit(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.masterTextureLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_masterTextureLimit(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.masterTextureLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anisotropicFiltering(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.anisotropicFiltering);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anisotropicFiltering(IntPtr l) {
		UnityEngine.AnisotropicFiltering v;
		checkEnum(l,2,out v);
		UnityEngine.QualitySettings.anisotropicFiltering=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lodBias(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.lodBias);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lodBias(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.lodBias=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumLODLevel(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.maximumLODLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumLODLevel(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.maximumLODLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleRaycastBudget(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.particleRaycastBudget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particleRaycastBudget(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.particleRaycastBudget=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_softVegetation(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.softVegetation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_softVegetation(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.softVegetation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxQueuedFrames(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.maxQueuedFrames);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxQueuedFrames(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.maxQueuedFrames=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vSyncCount(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.vSyncCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vSyncCount(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.vSyncCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_antiAliasing(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.antiAliasing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_antiAliasing(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.QualitySettings.antiAliasing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_desiredColorSpace(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.desiredColorSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activeColorSpace(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.activeColorSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendWeights(IntPtr l) {
		pushValue(l,UnityEngine.QualitySettings.blendWeights);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blendWeights(IntPtr l) {
		UnityEngine.BlendWeights v;
		checkEnum(l,2,out v);
		UnityEngine.QualitySettings.blendWeights=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.QualitySettings");
		addMember(l,GetQualityLevel, "GetQualityLevel");
		addMember(l,SetQualityLevel, "SetQualityLevel");
		addMember(l,IncreaseLevel, "IncreaseLevel");
		addMember(l,DecreaseLevel, "DecreaseLevel");
		addMember(l,get_names, "get_names");
		addMember(l,get_pixelLightCount, "get_pixelLightCount");
		addMember(l,set_pixelLightCount, "set_pixelLightCount");
		addMember(l,get_shadowProjection, "get_shadowProjection");
		addMember(l,set_shadowProjection, "set_shadowProjection");
		addMember(l,get_shadowCascades, "get_shadowCascades");
		addMember(l,set_shadowCascades, "set_shadowCascades");
		addMember(l,get_shadowDistance, "get_shadowDistance");
		addMember(l,set_shadowDistance, "set_shadowDistance");
		addMember(l,get_masterTextureLimit, "get_masterTextureLimit");
		addMember(l,set_masterTextureLimit, "set_masterTextureLimit");
		addMember(l,get_anisotropicFiltering, "get_anisotropicFiltering");
		addMember(l,set_anisotropicFiltering, "set_anisotropicFiltering");
		addMember(l,get_lodBias, "get_lodBias");
		addMember(l,set_lodBias, "set_lodBias");
		addMember(l,get_maximumLODLevel, "get_maximumLODLevel");
		addMember(l,set_maximumLODLevel, "set_maximumLODLevel");
		addMember(l,get_particleRaycastBudget, "get_particleRaycastBudget");
		addMember(l,set_particleRaycastBudget, "set_particleRaycastBudget");
		addMember(l,get_softVegetation, "get_softVegetation");
		addMember(l,set_softVegetation, "set_softVegetation");
		addMember(l,get_maxQueuedFrames, "get_maxQueuedFrames");
		addMember(l,set_maxQueuedFrames, "set_maxQueuedFrames");
		addMember(l,get_vSyncCount, "get_vSyncCount");
		addMember(l,set_vSyncCount, "set_vSyncCount");
		addMember(l,get_antiAliasing, "get_antiAliasing");
		addMember(l,set_antiAliasing, "set_antiAliasing");
		addMember(l,get_desiredColorSpace, "get_desiredColorSpace");
		addMember(l,get_activeColorSpace, "get_activeColorSpace");
		addMember(l,get_blendWeights, "get_blendWeights");
		addMember(l,set_blendWeights, "set_blendWeights");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.QualitySettings),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
