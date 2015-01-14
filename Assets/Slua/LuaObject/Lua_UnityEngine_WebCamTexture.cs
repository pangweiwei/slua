using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WebCamTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.WebCamTexture o;
		if(matchType(l,1,typeof(System.String),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.WebCamTexture(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String),typeof(System.Int32),typeof(System.Int32))){
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			o=new UnityEngine.WebCamTexture(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.WebCamTexture(a1);
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
			o=new UnityEngine.WebCamTexture(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.WebCamTexture(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1)){
			o=new UnityEngine.WebCamTexture();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
			self.Play();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Pause(IntPtr l) {
		try{
			UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
			self.Pause();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try{
			UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
			self.Stop();
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
			UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
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
	static public int GetPixels(IntPtr l) {
		try{
			if(matchType(l,2)){
				UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
				UnityEngine.Color[] ret=self.GetPixels();
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
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
			if(matchType(l,2,typeof(UnityEngine.Color32))){
				UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
				UnityEngine.Color32[] a1;
				checkType(l,2,out a1);
				UnityEngine.Color32[] ret=self.GetPixels32(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2)){
				UnityEngine.WebCamTexture self=checkSelf<UnityEngine.WebCamTexture>(l);
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
	static public int get_isPlaying(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceName(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.deviceName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_deviceName(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		System.String v;
		checkType(l,2,out v);
		o.deviceName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_requestedFPS(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.requestedFPS);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_requestedFPS(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		System.Single v;
		checkType(l,2,out v);
		o.requestedFPS=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_requestedWidth(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.requestedWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_requestedWidth(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.requestedWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_requestedHeight(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.requestedHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_requestedHeight(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.requestedHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_devices(IntPtr l) {
		pushValue(l,UnityEngine.WebCamTexture.devices);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_videoRotationAngle(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.videoRotationAngle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_videoVerticallyMirrored(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.videoVerticallyMirrored);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_didUpdateThisFrame(IntPtr l) {
		UnityEngine.WebCamTexture o = checkSelf<UnityEngine.WebCamTexture>(l);
		pushValue(l,o.didUpdateThisFrame);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WebCamTexture");
		addMember(l,Play, "Play");
		addMember(l,Pause, "Pause");
		addMember(l,Stop, "Stop");
		addMember(l,GetPixel, "GetPixel");
		addMember(l,GetPixels, "GetPixels");
		addMember(l,GetPixels32, "GetPixels32");
		addMember(l,get_isPlaying, "get_isPlaying");
		addMember(l,get_deviceName, "get_deviceName");
		addMember(l,set_deviceName, "set_deviceName");
		addMember(l,get_requestedFPS, "get_requestedFPS");
		addMember(l,set_requestedFPS, "set_requestedFPS");
		addMember(l,get_requestedWidth, "get_requestedWidth");
		addMember(l,set_requestedWidth, "set_requestedWidth");
		addMember(l,get_requestedHeight, "get_requestedHeight");
		addMember(l,set_requestedHeight, "set_requestedHeight");
		addMember(l,get_devices, "get_devices");
		addMember(l,get_videoRotationAngle, "get_videoRotationAngle");
		addMember(l,get_videoVerticallyMirrored, "get_videoVerticallyMirrored");
		addMember(l,get_didUpdateThisFrame, "get_didUpdateThisFrame");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.WebCamTexture),typeof(UnityEngine.Texture));
		LuaDLL.lua_pop(l, 1);
	}
}
