using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.RenderTexture o;
		if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.RenderTextureFormat),typeof(UnityEngine.RenderTextureReadWrite))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.RenderTextureFormat a4;
			checkEnum(l,4,out a4);
			UnityEngine.RenderTextureReadWrite a5;
			checkEnum(l,5,out a5);
			o=new UnityEngine.RenderTexture(a1,a2,a3,a4,a5);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.RenderTextureFormat))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.RenderTextureFormat a4;
			checkEnum(l,4,out a4);
			o=new UnityEngine.RenderTexture(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			o=new UnityEngine.RenderTexture(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTemporary(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.RenderTextureFormat),typeof(UnityEngine.RenderTextureReadWrite),typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,4,out a4);
				UnityEngine.RenderTextureReadWrite a5;
				checkEnum(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.RenderTexture ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.RenderTextureFormat),typeof(UnityEngine.RenderTextureReadWrite))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,4,out a4);
				UnityEngine.RenderTextureReadWrite a5;
				checkEnum(l,5,out a5);
				UnityEngine.RenderTexture ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.RenderTextureFormat))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RenderTextureFormat a4;
				checkEnum(l,4,out a4);
				UnityEngine.RenderTexture ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RenderTexture ret=UnityEngine.RenderTexture.GetTemporary(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.RenderTexture ret=UnityEngine.RenderTexture.GetTemporary(a1,a2);
				pushValue(l,ret);
				return 1;
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
	static public int ReleaseTemporary(IntPtr l) {
		try{
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture.ReleaseTemporary(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create(IntPtr l) {
		try{
			UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
			System.Boolean ret=self.Create();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Release(IntPtr l) {
		try{
			UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
			self.Release();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsCreated(IntPtr l) {
		try{
			UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
			System.Boolean ret=self.IsCreated();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DiscardContents(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
				self.DiscardContents();
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean),typeof(System.Boolean))){
				UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.DiscardContents(a1,a2);
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
	static public int MarkRestoreExpected(IntPtr l) {
		try{
			UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
			self.MarkRestoreExpected();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetGlobalShaderProperty(IntPtr l) {
		try{
			UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SetGlobalShaderProperty(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTexelOffset(IntPtr l) {
		try{
			UnityEngine.RenderTexture self=checkSelf<UnityEngine.RenderTexture>(l);
			UnityEngine.Vector2 ret=self.GetTexelOffset();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SupportsStencil(IntPtr l) {
		try{
			UnityEngine.RenderTexture a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.RenderTexture.SupportsStencil(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.depth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPowerOfTwo(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.isPowerOfTwo);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isPowerOfTwo(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isPowerOfTwo=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sRGB(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.sRGB);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_format(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.format);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_format(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		UnityEngine.RenderTextureFormat v;
		checkEnum(l,2,out v);
		o.format=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMipMap(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.useMipMap);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMipMap(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useMipMap=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_generateMips(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.generateMips);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_generateMips(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.generateMips=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isCubemap(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.isCubemap);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isCubemap(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isCubemap=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isVolume(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.isVolume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isVolume(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isVolume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_volumeDepth(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.volumeDepth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_volumeDepth(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.volumeDepth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_antiAliasing(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.antiAliasing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_antiAliasing(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.antiAliasing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableRandomWrite(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.enableRandomWrite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableRandomWrite(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enableRandomWrite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorBuffer(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.colorBuffer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthBuffer(IntPtr l) {
		UnityEngine.RenderTexture o = checkSelf<UnityEngine.RenderTexture>(l);
		pushValue(l,o.depthBuffer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_active(IntPtr l) {
		pushValue(l,UnityEngine.RenderTexture.active);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_active(IntPtr l) {
		UnityEngine.RenderTexture v;
		checkType(l,2,out v);
		UnityEngine.RenderTexture.active=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderTexture");
		addMember(l,GetTemporary, "GetTemporary");
		addMember(l,ReleaseTemporary, "ReleaseTemporary");
		addMember(l,Create, "Create");
		addMember(l,Release, "Release");
		addMember(l,IsCreated, "IsCreated");
		addMember(l,DiscardContents, "DiscardContents");
		addMember(l,MarkRestoreExpected, "MarkRestoreExpected");
		addMember(l,SetGlobalShaderProperty, "SetGlobalShaderProperty");
		addMember(l,GetTexelOffset, "GetTexelOffset");
		addMember(l,SupportsStencil, "SupportsStencil");
		addMember(l,get_width, "get_width");
		addMember(l,set_width, "set_width");
		addMember(l,get_height, "get_height");
		addMember(l,set_height, "set_height");
		addMember(l,get_depth, "get_depth");
		addMember(l,set_depth, "set_depth");
		addMember(l,get_isPowerOfTwo, "get_isPowerOfTwo");
		addMember(l,set_isPowerOfTwo, "set_isPowerOfTwo");
		addMember(l,get_sRGB, "get_sRGB");
		addMember(l,get_format, "get_format");
		addMember(l,set_format, "set_format");
		addMember(l,get_useMipMap, "get_useMipMap");
		addMember(l,set_useMipMap, "set_useMipMap");
		addMember(l,get_generateMips, "get_generateMips");
		addMember(l,set_generateMips, "set_generateMips");
		addMember(l,get_isCubemap, "get_isCubemap");
		addMember(l,set_isCubemap, "set_isCubemap");
		addMember(l,get_isVolume, "get_isVolume");
		addMember(l,set_isVolume, "set_isVolume");
		addMember(l,get_volumeDepth, "get_volumeDepth");
		addMember(l,set_volumeDepth, "set_volumeDepth");
		addMember(l,get_antiAliasing, "get_antiAliasing");
		addMember(l,set_antiAliasing, "set_antiAliasing");
		addMember(l,get_enableRandomWrite, "get_enableRandomWrite");
		addMember(l,set_enableRandomWrite, "set_enableRandomWrite");
		addMember(l,get_colorBuffer, "get_colorBuffer");
		addMember(l,get_depthBuffer, "get_depthBuffer");
		addMember(l,get_active, "get_active");
		addMember(l,set_active, "set_active");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Texture));
		LuaDLL.lua_pop(l, 1);
	}
}
