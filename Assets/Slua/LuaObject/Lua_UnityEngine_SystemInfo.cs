using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SystemInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SystemInfo o;
		if(matchType(l,1)){
			o=new UnityEngine.SystemInfo();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SupportsRenderTextureFormat(IntPtr l) {
		try{
			UnityEngine.RenderTextureFormat a1;
			checkEnum(l,1,out a1);
			System.Boolean ret=UnityEngine.SystemInfo.SupportsRenderTextureFormat(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_operatingSystem(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.operatingSystem);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_processorType(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.processorType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_processorCount(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.processorCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemMemorySize(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.systemMemorySize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsMemorySize(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsMemorySize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceName(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsDeviceName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceVendor(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsDeviceVendor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceID(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsDeviceID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceVendorID(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsDeviceVendorID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsDeviceVersion(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsDeviceVersion);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsShaderLevel(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsShaderLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphicsPixelFillrate(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.graphicsPixelFillrate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsShadows(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsShadows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsRenderTextures(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsRenderTextures);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsRenderToCubemap(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsRenderToCubemap);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsImageEffects(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsImageEffects);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supports3DTextures(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supports3DTextures);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsComputeShaders(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsComputeShaders);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsInstancing(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsInstancing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsSparseTextures(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsSparseTextures);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportedRenderTargetCount(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportedRenderTargetCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsStencil(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsStencil);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsVertexPrograms(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsVertexPrograms);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_npotSupport(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.npotSupport);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceUniqueIdentifier(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.deviceUniqueIdentifier);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceName(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.deviceName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceModel(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.deviceModel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsAccelerometer(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsAccelerometer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsGyroscope(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsGyroscope);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsLocationService(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsLocationService);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supportsVibration(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.supportsVibration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceType(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.deviceType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxTextureSize(IntPtr l) {
		pushValue(l,UnityEngine.SystemInfo.maxTextureSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SystemInfo");
		addMember(l,SupportsRenderTextureFormat);
		addMember(l,"operatingSystem",get_operatingSystem,null);
		addMember(l,"processorType",get_processorType,null);
		addMember(l,"processorCount",get_processorCount,null);
		addMember(l,"systemMemorySize",get_systemMemorySize,null);
		addMember(l,"graphicsMemorySize",get_graphicsMemorySize,null);
		addMember(l,"graphicsDeviceName",get_graphicsDeviceName,null);
		addMember(l,"graphicsDeviceVendor",get_graphicsDeviceVendor,null);
		addMember(l,"graphicsDeviceID",get_graphicsDeviceID,null);
		addMember(l,"graphicsDeviceVendorID",get_graphicsDeviceVendorID,null);
		addMember(l,"graphicsDeviceVersion",get_graphicsDeviceVersion,null);
		addMember(l,"graphicsShaderLevel",get_graphicsShaderLevel,null);
		addMember(l,"graphicsPixelFillrate",get_graphicsPixelFillrate,null);
		addMember(l,"supportsShadows",get_supportsShadows,null);
		addMember(l,"supportsRenderTextures",get_supportsRenderTextures,null);
		addMember(l,"supportsRenderToCubemap",get_supportsRenderToCubemap,null);
		addMember(l,"supportsImageEffects",get_supportsImageEffects,null);
		addMember(l,"supports3DTextures",get_supports3DTextures,null);
		addMember(l,"supportsComputeShaders",get_supportsComputeShaders,null);
		addMember(l,"supportsInstancing",get_supportsInstancing,null);
		addMember(l,"supportsSparseTextures",get_supportsSparseTextures,null);
		addMember(l,"supportedRenderTargetCount",get_supportedRenderTargetCount,null);
		addMember(l,"supportsStencil",get_supportsStencil,null);
		addMember(l,"supportsVertexPrograms",get_supportsVertexPrograms,null);
		addMember(l,"npotSupport",get_npotSupport,null);
		addMember(l,"deviceUniqueIdentifier",get_deviceUniqueIdentifier,null);
		addMember(l,"deviceName",get_deviceName,null);
		addMember(l,"deviceModel",get_deviceModel,null);
		addMember(l,"supportsAccelerometer",get_supportsAccelerometer,null);
		addMember(l,"supportsGyroscope",get_supportsGyroscope,null);
		addMember(l,"supportsLocationService",get_supportsLocationService,null);
		addMember(l,"supportsVibration",get_supportsVibration,null);
		addMember(l,"deviceType",get_deviceType,null);
		addMember(l,"maxTextureSize",get_maxTextureSize,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SystemInfo));
	}
}
