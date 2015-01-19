using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioClip : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioClip o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioClip();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetData(IntPtr l) {
		try{
			UnityEngine.AudioClip self=checkSelf<UnityEngine.AudioClip>(l);
			System.Single[] a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.GetData(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetData(IntPtr l) {
		try{
			UnityEngine.AudioClip self=checkSelf<UnityEngine.AudioClip>(l);
			System.Single[] a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetData(a1,a2);
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
			if(matchType(l,1,typeof(System.String),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Boolean),typeof(System.Boolean))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean a5;
				checkType(l,5,out a5);
				System.Boolean a6;
				checkType(l,6,out a6);
				UnityEngine.AudioClip ret=UnityEngine.AudioClip.Create(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Boolean),typeof(System.Boolean),typeof(UnityEngine.AudioClip.PCMReaderCallback))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean a5;
				checkType(l,5,out a5);
				System.Boolean a6;
				checkType(l,6,out a6);
				UnityEngine.AudioClip.PCMReaderCallback a7;
				checkDelegate(l,7,out a7);
				UnityEngine.AudioClip ret=UnityEngine.AudioClip.Create(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Int32),typeof(System.Int32),typeof(System.Int32),typeof(System.Boolean),typeof(System.Boolean),typeof(UnityEngine.AudioClip.PCMReaderCallback),typeof(UnityEngine.AudioClip.PCMSetPositionCallback))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean a5;
				checkType(l,5,out a5);
				System.Boolean a6;
				checkType(l,6,out a6);
				UnityEngine.AudioClip.PCMReaderCallback a7;
				checkDelegate(l,7,out a7);
				UnityEngine.AudioClip.PCMSetPositionCallback a8;
				checkDelegate(l,8,out a8);
				UnityEngine.AudioClip ret=UnityEngine.AudioClip.Create(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int get_length(IntPtr l) {
		UnityEngine.AudioClip o = checkSelf<UnityEngine.AudioClip>(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_samples(IntPtr l) {
		UnityEngine.AudioClip o = checkSelf<UnityEngine.AudioClip>(l);
		pushValue(l,o.samples);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_channels(IntPtr l) {
		UnityEngine.AudioClip o = checkSelf<UnityEngine.AudioClip>(l);
		pushValue(l,o.channels);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frequency(IntPtr l) {
		UnityEngine.AudioClip o = checkSelf<UnityEngine.AudioClip>(l);
		pushValue(l,o.frequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isReadyToPlay(IntPtr l) {
		UnityEngine.AudioClip o = checkSelf<UnityEngine.AudioClip>(l);
		pushValue(l,o.isReadyToPlay);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioClip");
		addMember(l,GetData, "GetData");
		addMember(l,SetData, "SetData");
		addMember(l,Create, "Create");
		addMember(l,get_length, "get_length");
		addMember(l,get_samples, "get_samples");
		addMember(l,get_channels, "get_channels");
		addMember(l,get_frequency, "get_frequency");
		addMember(l,get_isReadyToPlay, "get_isReadyToPlay");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioClip),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
