using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Texture2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Texture2D o;
		if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Texture2D(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.TextureFormat),typeof(System.Boolean))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.TextureFormat),typeof(System.Boolean),typeof(System.Boolean))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4,a5);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateExternalTexture(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			self.UpdateExternalTexture(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPixel(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			self.SetPixel(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixel(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Color ret=self.GetPixel(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixelBilinear(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.Color ret=self.GetPixelBilinear(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPixels(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Color))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Color[] a1;
				checkType(l,2,out a1);
				self.SetPixels(a1);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Color),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Color[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetPixels(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.Color),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.Color[] a5;
				checkType(l,6,out a5);
				System.Int32 a6;
				checkType(l,7,out a6);
				self.SetPixels(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.Color))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.Color[] a5;
				checkType(l,6,out a5);
				self.SetPixels(a1,a2,a3,a4,a5);
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
	static public int SetPixels32(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Color32),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Color32[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetPixels32(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Color32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Color32[] a1;
				checkType(l,2,out a1);
				self.SetPixels32(a1);
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
	static public int LoadImage(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Byte[] a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.LoadImage(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadRawTextureData(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Byte[] a1;
			checkType(l,2,out a1);
			self.LoadRawTextureData(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixels(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Color[] ret=self.GetPixels();
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color[] ret=self.GetPixels(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				UnityEngine.Color[] ret=self.GetPixels(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.Color[] ret=self.GetPixels(a1,a2,a3,a4);
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
	static public int GetPixels32(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color32[] ret=self.GetPixels32(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2)){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Color32[] ret=self.GetPixels32();
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
	static public int Apply(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Boolean),typeof(System.Boolean))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Apply(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Apply(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				self.Apply();
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
	static public int Resize(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.TextureFormat),typeof(System.Boolean))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.TextureFormat a3;
				checkEnum(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				System.Boolean ret=self.Resize(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Boolean ret=self.Resize(a1,a2);
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
	static public int Compress(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Compress(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PackTextures(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Texture2D),typeof(System.Int32),typeof(System.Int32),typeof(System.Boolean))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Texture2D[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				UnityEngine.Rect[] ret=self.PackTextures(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Texture2D),typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Texture2D[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.Rect[] ret=self.PackTextures(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Texture2D),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Texture2D[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Rect[] ret=self.PackTextures(a1,a2);
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
	static public int ReadPixels(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Rect),typeof(System.Int32),typeof(System.Int32),typeof(System.Boolean))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				self.ReadPixels(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Rect),typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				UnityEngine.Rect a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.ReadPixels(a1,a2,a3);
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
	static public int EncodeToPNG(IntPtr l) {
		try{
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Byte[] ret=self.EncodeToPNG();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EncodeToJPG(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Byte[] ret=self.EncodeToJPG(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2)){
				UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
				System.Byte[] ret=self.EncodeToJPG();
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
	static public int CreateExternalTexture_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			System.IntPtr a6;
			checkType(l,6,out a6);
			UnityEngine.Texture2D ret=UnityEngine.Texture2D.CreateExternalTexture(a1,a2,a3,a4,a5,a6);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mipmapCount(IntPtr l) {
		UnityEngine.Texture2D o = (UnityEngine.Texture2D)checkSelf(l);
		pushValue(l,o.mipmapCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_format(IntPtr l) {
		UnityEngine.Texture2D o = (UnityEngine.Texture2D)checkSelf(l);
		pushValue(l,o.format);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_whiteTexture(IntPtr l) {
		pushValue(l,UnityEngine.Texture2D.whiteTexture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blackTexture(IntPtr l) {
		pushValue(l,UnityEngine.Texture2D.blackTexture);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture2D");
		addMember(l,UpdateExternalTexture);
		addMember(l,SetPixel);
		addMember(l,GetPixel);
		addMember(l,GetPixelBilinear);
		addMember(l,SetPixels);
		addMember(l,SetPixels32);
		addMember(l,LoadImage);
		addMember(l,LoadRawTextureData);
		addMember(l,GetPixels);
		addMember(l,GetPixels32);
		addMember(l,Apply);
		addMember(l,Resize);
		addMember(l,Compress);
		addMember(l,PackTextures);
		addMember(l,ReadPixels);
		addMember(l,EncodeToPNG);
		addMember(l,EncodeToJPG);
		addMember(l,CreateExternalTexture_s);
		addMember(l,"mipmapCount",get_mipmapCount,null);
		addMember(l,"format",get_format,null);
		addMember(l,"whiteTexture",get_whiteTexture,null);
		addMember(l,"blackTexture",get_blackTexture,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Texture2D),typeof(UnityEngine.Texture));
	}
}
