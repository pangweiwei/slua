using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Texture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Texture o;
		if(matchType(l,1)){
			o=new UnityEngine.Texture();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNativeTexturePtr(IntPtr l) {
		try{
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			System.IntPtr ret=self.GetNativeTexturePtr();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNativeTextureID(IntPtr l) {
		try{
			UnityEngine.Texture self=(UnityEngine.Texture)checkSelf(l);
			System.Int32 ret=self.GetNativeTextureID();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetGlobalAnisotropicFilteringLimits_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Texture.SetGlobalAnisotropicFilteringLimits(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_masterTextureLimit(IntPtr l) {
		pushValue(l,UnityEngine.Texture.masterTextureLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_masterTextureLimit(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.Texture.masterTextureLimit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anisotropicFiltering(IntPtr l) {
		pushValue(l,UnityEngine.Texture.anisotropicFiltering);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anisotropicFiltering(IntPtr l) {
		UnityEngine.AnisotropicFiltering v;
		checkEnum(l,2,out v);
		UnityEngine.Texture.anisotropicFiltering=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_filterMode(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		pushValue(l,o.filterMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_filterMode(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		UnityEngine.FilterMode v;
		checkEnum(l,2,out v);
		o.filterMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anisoLevel(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		pushValue(l,o.anisoLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anisoLevel(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.anisoLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wrapMode(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		pushValue(l,o.wrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wrapMode(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		UnityEngine.TextureWrapMode v;
		checkEnum(l,2,out v);
		o.wrapMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mipMapBias(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		pushValue(l,o.mipMapBias);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mipMapBias(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.mipMapBias=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texelSize(IntPtr l) {
		UnityEngine.Texture o = (UnityEngine.Texture)checkSelf(l);
		pushValue(l,o.texelSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture");
		addMember(l,GetNativeTexturePtr);
		addMember(l,GetNativeTextureID);
		addMember(l,SetGlobalAnisotropicFilteringLimits_s);
		addMember(l,"masterTextureLimit",get_masterTextureLimit,set_masterTextureLimit,false);
		addMember(l,"anisotropicFiltering",get_anisotropicFiltering,set_anisotropicFiltering,false);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"filterMode",get_filterMode,set_filterMode,true);
		addMember(l,"anisoLevel",get_anisoLevel,set_anisoLevel,true);
		addMember(l,"wrapMode",get_wrapMode,set_wrapMode,true);
		addMember(l,"mipMapBias",get_mipMapBias,set_mipMapBias,true);
		addMember(l,"texelSize",get_texelSize,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Texture),typeof(UnityEngine.Object));
	}
}
