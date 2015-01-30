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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetQualityLevel_s(IntPtr l) {
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
	static public int SetQualityLevel_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(int),typeof(bool))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				UnityEngine.QualitySettings.SetQualityLevel(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(int))){
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
	static public int IncreaseLevel_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(bool))){
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
	static public int DecreaseLevel_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(bool))){
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
		int v;
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
		int v;
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
		float v;
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
		int v;
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
		float v;
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
		int v;
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
		int v;
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
		bool v;
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
		int v;
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
		int v;
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
		int v;
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
		addMember(l,GetQualityLevel_s);
		addMember(l,SetQualityLevel_s);
		addMember(l,IncreaseLevel_s);
		addMember(l,DecreaseLevel_s);
		addMember(l,"names",get_names,null,false);
		addMember(l,"pixelLightCount",get_pixelLightCount,set_pixelLightCount,false);
		addMember(l,"shadowProjection",get_shadowProjection,set_shadowProjection,false);
		addMember(l,"shadowCascades",get_shadowCascades,set_shadowCascades,false);
		addMember(l,"shadowDistance",get_shadowDistance,set_shadowDistance,false);
		addMember(l,"masterTextureLimit",get_masterTextureLimit,set_masterTextureLimit,false);
		addMember(l,"anisotropicFiltering",get_anisotropicFiltering,set_anisotropicFiltering,false);
		addMember(l,"lodBias",get_lodBias,set_lodBias,false);
		addMember(l,"maximumLODLevel",get_maximumLODLevel,set_maximumLODLevel,false);
		addMember(l,"particleRaycastBudget",get_particleRaycastBudget,set_particleRaycastBudget,false);
		addMember(l,"softVegetation",get_softVegetation,set_softVegetation,false);
		addMember(l,"maxQueuedFrames",get_maxQueuedFrames,set_maxQueuedFrames,false);
		addMember(l,"vSyncCount",get_vSyncCount,set_vSyncCount,false);
		addMember(l,"antiAliasing",get_antiAliasing,set_antiAliasing,false);
		addMember(l,"desiredColorSpace",get_desiredColorSpace,null,false);
		addMember(l,"activeColorSpace",get_activeColorSpace,null,false);
		addMember(l,"blendWeights",get_blendWeights,set_blendWeights,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.QualitySettings),typeof(UnityEngine.Object));
	}
}
