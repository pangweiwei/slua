using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Cubemap : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Cubemap o;
		if(matchType(l,1,typeof(System.Int32),typeof(UnityEngine.TextureFormat),typeof(System.Boolean))){
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.TextureFormat a2;
			checkEnum(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Cubemap(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPixel(IntPtr l) {
		try{
			UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
			UnityEngine.CubemapFace a1;
			checkEnum(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Color a4;
			checkType(l,5,out a4);
			self.SetPixel(a1,a2,a3,a4);
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
			UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
			UnityEngine.CubemapFace a1;
			checkEnum(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Color ret=self.GetPixel(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixels(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.CubemapFace),typeof(System.Int32))){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				UnityEngine.CubemapFace a1;
				checkEnum(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Color[] ret=self.GetPixels(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.CubemapFace))){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				UnityEngine.CubemapFace a1;
				checkEnum(l,2,out a1);
				UnityEngine.Color[] ret=self.GetPixels(a1);
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
	static public int SetPixels(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.Color),typeof(UnityEngine.CubemapFace),typeof(System.Int32))){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				UnityEngine.Color[] a1;
				checkType(l,2,out a1);
				UnityEngine.CubemapFace a2;
				checkEnum(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.SetPixels(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.Color),typeof(UnityEngine.CubemapFace))){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				UnityEngine.Color[] a1;
				checkType(l,2,out a1);
				UnityEngine.CubemapFace a2;
				checkEnum(l,3,out a2);
				self.SetPixels(a1,a2);
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
	static public int Apply(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Boolean),typeof(System.Boolean))){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Apply(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Apply(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
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
	static public int SmoothEdges(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32))){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.SmoothEdges(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.Cubemap self=(UnityEngine.Cubemap)checkSelf(l);
				self.SmoothEdges();
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
	static public int get_format(IntPtr l) {
		UnityEngine.Cubemap o = (UnityEngine.Cubemap)checkSelf(l);
		pushValue(l,o.format);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Cubemap");
		addMember(l,SetPixel);
		addMember(l,GetPixel);
		addMember(l,GetPixels);
		addMember(l,SetPixels);
		addMember(l,Apply);
		addMember(l,SmoothEdges);
		addMember(l,"format",get_format,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Cubemap),typeof(UnityEngine.Texture));
	}
}
