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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create(IntPtr l) {
		try{
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
				UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
				self.DiscardContents();
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean),typeof(System.Boolean))){
				UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
			UnityEngine.RenderTexture self=(UnityEngine.RenderTexture)checkSelf(l);
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
	static public int GetTemporary_s(IntPtr l) {
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
	static public int ReleaseTemporary_s(IntPtr l) {
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
	static public int SupportsStencil_s(IntPtr l) {
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
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.depth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPowerOfTwo(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.isPowerOfTwo);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isPowerOfTwo(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isPowerOfTwo=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sRGB(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.sRGB);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_format(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.format);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_format(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		UnityEngine.RenderTextureFormat v;
		checkEnum(l,2,out v);
		o.format=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useMipMap(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.useMipMap);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useMipMap(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useMipMap=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_generateMips(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.generateMips);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_generateMips(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.generateMips=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isCubemap(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.isCubemap);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isCubemap(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isCubemap=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isVolume(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.isVolume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isVolume(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isVolume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_volumeDepth(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.volumeDepth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_volumeDepth(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.volumeDepth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_antiAliasing(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.antiAliasing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_antiAliasing(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.antiAliasing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableRandomWrite(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.enableRandomWrite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableRandomWrite(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enableRandomWrite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorBuffer(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
		pushValue(l,o.colorBuffer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthBuffer(IntPtr l) {
		UnityEngine.RenderTexture o = (UnityEngine.RenderTexture)checkSelf(l);
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
		addMember(l,Create);
		addMember(l,Release);
		addMember(l,IsCreated);
		addMember(l,DiscardContents);
		addMember(l,MarkRestoreExpected);
		addMember(l,SetGlobalShaderProperty);
		addMember(l,GetTexelOffset);
		addMember(l,GetTemporary_s);
		addMember(l,ReleaseTemporary_s);
		addMember(l,SupportsStencil_s);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"isPowerOfTwo",get_isPowerOfTwo,set_isPowerOfTwo,true);
		addMember(l,"sRGB",get_sRGB,null,true);
		addMember(l,"format",get_format,set_format,true);
		addMember(l,"useMipMap",get_useMipMap,set_useMipMap,true);
		addMember(l,"generateMips",get_generateMips,set_generateMips,true);
		addMember(l,"isCubemap",get_isCubemap,set_isCubemap,true);
		addMember(l,"isVolume",get_isVolume,set_isVolume,true);
		addMember(l,"volumeDepth",get_volumeDepth,set_volumeDepth,true);
		addMember(l,"antiAliasing",get_antiAliasing,set_antiAliasing,true);
		addMember(l,"enableRandomWrite",get_enableRandomWrite,set_enableRandomWrite,true);
		addMember(l,"colorBuffer",get_colorBuffer,null,true);
		addMember(l,"depthBuffer",get_depthBuffer,null,true);
		addMember(l,"active",get_active,set_active,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Texture));
	}
}
