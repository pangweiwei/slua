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
		addMember(l,SupportsRenderTextureFormat, "SupportsRenderTextureFormat");
		addMember(l,get_operatingSystem, "get_operatingSystem");
		addMember(l,get_processorType, "get_processorType");
		addMember(l,get_processorCount, "get_processorCount");
		addMember(l,get_systemMemorySize, "get_systemMemorySize");
		addMember(l,get_graphicsMemorySize, "get_graphicsMemorySize");
		addMember(l,get_graphicsDeviceName, "get_graphicsDeviceName");
		addMember(l,get_graphicsDeviceVendor, "get_graphicsDeviceVendor");
		addMember(l,get_graphicsDeviceID, "get_graphicsDeviceID");
		addMember(l,get_graphicsDeviceVendorID, "get_graphicsDeviceVendorID");
		addMember(l,get_graphicsDeviceVersion, "get_graphicsDeviceVersion");
		addMember(l,get_graphicsShaderLevel, "get_graphicsShaderLevel");
		addMember(l,get_graphicsPixelFillrate, "get_graphicsPixelFillrate");
		addMember(l,get_supportsShadows, "get_supportsShadows");
		addMember(l,get_supportsRenderTextures, "get_supportsRenderTextures");
		addMember(l,get_supportsRenderToCubemap, "get_supportsRenderToCubemap");
		addMember(l,get_supportsImageEffects, "get_supportsImageEffects");
		addMember(l,get_supports3DTextures, "get_supports3DTextures");
		addMember(l,get_supportsComputeShaders, "get_supportsComputeShaders");
		addMember(l,get_supportsInstancing, "get_supportsInstancing");
		addMember(l,get_supportsSparseTextures, "get_supportsSparseTextures");
		addMember(l,get_supportedRenderTargetCount, "get_supportedRenderTargetCount");
		addMember(l,get_supportsStencil, "get_supportsStencil");
		addMember(l,get_supportsVertexPrograms, "get_supportsVertexPrograms");
		addMember(l,get_npotSupport, "get_npotSupport");
		addMember(l,get_deviceUniqueIdentifier, "get_deviceUniqueIdentifier");
		addMember(l,get_deviceName, "get_deviceName");
		addMember(l,get_deviceModel, "get_deviceModel");
		addMember(l,get_supportsAccelerometer, "get_supportsAccelerometer");
		addMember(l,get_supportsGyroscope, "get_supportsGyroscope");
		addMember(l,get_supportsLocationService, "get_supportsLocationService");
		addMember(l,get_supportsVibration, "get_supportsVibration");
		addMember(l,get_deviceType, "get_deviceType");
		addMember(l,get_maxTextureSize, "get_maxTextureSize");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.SystemInfo));
		LuaDLL.lua_pop(l, 1);
	}
}
