﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioListener : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AudioListener o;
		o=new UnityEngine.AudioListener();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOutputData_s(IntPtr l) {
		try{
			System.Single[] a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.AudioListener.GetOutputData(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSpectrumData_s(IntPtr l) {
		try{
			System.Single[] a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.FFTWindow a3;
			checkEnum(l,3,out a3);
			UnityEngine.AudioListener.GetSpectrumData(a1,a2,a3);
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
		float v;
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
		bool v;
		checkType(l,2,out v);
		UnityEngine.AudioListener.pause=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioListener o = (UnityEngine.AudioListener)checkSelf(l);
		pushEnum(l,(int)o.velocityUpdateMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioListener o = (UnityEngine.AudioListener)checkSelf(l);
		UnityEngine.AudioVelocityUpdateMode v;
		checkEnum(l,2,out v);
		o.velocityUpdateMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioListener");
		addMember(l,GetOutputData_s);
		addMember(l,GetSpectrumData_s);
		addMember(l,"volume",get_volume,set_volume,false);
		addMember(l,"pause",get_pause,set_pause,false);
		addMember(l,"velocityUpdateMode",get_velocityUpdateMode,set_velocityUpdateMode,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioListener),typeof(UnityEngine.Behaviour));
	}
}
