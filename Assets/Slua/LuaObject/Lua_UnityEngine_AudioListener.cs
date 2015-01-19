using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioListener : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioListener o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioListener();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOutputData(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single[] ret=UnityEngine.AudioListener.GetOutputData(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Single),typeof(System.Int32))){
				System.Single[] a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.AudioListener.GetOutputData(a1,a2);
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
	static public int GetSpectrumData(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.FFTWindow))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.FFTWindow a3;
				checkEnum(l,3,out a3);
				System.Single[] ret=UnityEngine.AudioListener.GetSpectrumData(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Single),typeof(System.Int32),typeof(UnityEngine.FFTWindow))){
				System.Single[] a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.FFTWindow a3;
				checkEnum(l,3,out a3);
				UnityEngine.AudioListener.GetSpectrumData(a1,a2,a3);
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
	static public int get_volume(IntPtr l) {
		pushValue(l,UnityEngine.AudioListener.volume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_volume(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.AudioListener.volume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pause(IntPtr l) {
		pushValue(l,UnityEngine.AudioListener.pause);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pause(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.AudioListener.pause=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioListener o = checkSelf<UnityEngine.AudioListener>(l);
		pushValue(l,o.velocityUpdateMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioListener o = checkSelf<UnityEngine.AudioListener>(l);
		UnityEngine.AudioVelocityUpdateMode v;
		checkEnum(l,2,out v);
		o.velocityUpdateMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioListener");
		addMember(l,GetOutputData, "GetOutputData");
		addMember(l,GetSpectrumData, "GetSpectrumData");
		addMember(l,get_volume, "get_volume");
		addMember(l,set_volume, "set_volume");
		addMember(l,get_pause, "get_pause");
		addMember(l,set_pause, "set_pause");
		addMember(l,get_velocityUpdateMode, "get_velocityUpdateMode");
		addMember(l,set_velocityUpdateMode, "set_velocityUpdateMode");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioListener),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
