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
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetGlobalAnisotropicFilteringLimits(IntPtr l) {
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
	static public int GetNativeTexturePtr(IntPtr l) {
		try{
			UnityEngine.Texture self=checkSelf<UnityEngine.Texture>(l);
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
			UnityEngine.Texture self=checkSelf<UnityEngine.Texture>(l);
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
	static public int get_masterTextureLimit(IntPtr l) {
		pushValue(l,UnityEngine.Texture.masterTextureLimit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_masterTextureLimit(IntPtr l) {
		System.Int32 v;
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
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_filterMode(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		pushValue(l,o.filterMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_filterMode(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		UnityEngine.FilterMode v;
		checkEnum(l,2,out v);
		o.filterMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anisoLevel(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		pushValue(l,o.anisoLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anisoLevel(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.anisoLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wrapMode(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		pushValue(l,o.wrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wrapMode(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		UnityEngine.TextureWrapMode v;
		checkEnum(l,2,out v);
		o.wrapMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mipMapBias(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		pushValue(l,o.mipMapBias);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mipMapBias(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		System.Single v;
		checkType(l,2,out v);
		o.mipMapBias=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texelSize(IntPtr l) {
		UnityEngine.Texture o = checkSelf<UnityEngine.Texture>(l);
		pushValue(l,o.texelSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture");
		addMember(l,SetGlobalAnisotropicFilteringLimits, "SetGlobalAnisotropicFilteringLimits");
		addMember(l,GetNativeTexturePtr, "GetNativeTexturePtr");
		addMember(l,GetNativeTextureID, "GetNativeTextureID");
		addMember(l,get_masterTextureLimit, "get_masterTextureLimit");
		addMember(l,set_masterTextureLimit, "set_masterTextureLimit");
		addMember(l,get_anisotropicFiltering, "get_anisotropicFiltering");
		addMember(l,set_anisotropicFiltering, "set_anisotropicFiltering");
		addMember(l,get_width, "get_width");
		addMember(l,set_width, "set_width");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_filterMode, "get_filterMode");
		addMember(l,set_filterMode, "set_filterMode");
		addMember(l,get_anisoLevel, "get_anisoLevel");
		addMember(l,set_anisoLevel, "set_anisoLevel");
		addMember(l,get_wrapMode, "get_wrapMode");
		addMember(l,set_wrapMode, "set_wrapMode");
		addMember(l,get_mipMapBias, "get_mipMapBias");
		addMember(l,set_mipMapBias, "set_mipMapBias");
		addMember(l,get_texelSize, "get_texelSize");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Texture),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
