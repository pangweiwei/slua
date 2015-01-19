using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationClip : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AnimationClip o;
		if(matchType(l,1)){
			o=new UnityEngine.AnimationClip();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetCurve(IntPtr l) {
		try{
			UnityEngine.AnimationClip self=checkSelf<UnityEngine.AnimationClip>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			UnityEngine.AnimationCurve a4;
			checkType(l,5,out a4);
			self.SetCurve(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnsureQuaternionContinuity(IntPtr l) {
		try{
			UnityEngine.AnimationClip self=checkSelf<UnityEngine.AnimationClip>(l);
			self.EnsureQuaternionContinuity();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearCurves(IntPtr l) {
		try{
			UnityEngine.AnimationClip self=checkSelf<UnityEngine.AnimationClip>(l);
			self.ClearCurves();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddEvent(IntPtr l) {
		try{
			UnityEngine.AnimationClip self=checkSelf<UnityEngine.AnimationClip>(l);
			UnityEngine.AnimationEvent a1;
			checkType(l,2,out a1);
			self.AddEvent(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		UnityEngine.AnimationClip o = checkSelf<UnityEngine.AnimationClip>(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frameRate(IntPtr l) {
		UnityEngine.AnimationClip o = checkSelf<UnityEngine.AnimationClip>(l);
		pushValue(l,o.frameRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frameRate(IntPtr l) {
		UnityEngine.AnimationClip o = checkSelf<UnityEngine.AnimationClip>(l);
		System.Single v;
		checkType(l,2,out v);
		o.frameRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wrapMode(IntPtr l) {
		UnityEngine.AnimationClip o = checkSelf<UnityEngine.AnimationClip>(l);
		pushValue(l,o.wrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wrapMode(IntPtr l) {
		UnityEngine.AnimationClip o = checkSelf<UnityEngine.AnimationClip>(l);
		UnityEngine.WrapMode v;
		checkEnum(l,2,out v);
		o.wrapMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localBounds(IntPtr l) {
		UnityEngine.AnimationClip o = checkSelf<UnityEngine.AnimationClip>(l);
		pushValue(l,o.localBounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localBounds(IntPtr l) {
		UnityEngine.AnimationClip o = checkSelf<UnityEngine.AnimationClip>(l);
		UnityEngine.Bounds v;
		checkType(l,2,out v);
		o.localBounds=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationClip");
		addMember(l,SetCurve, "SetCurve");
		addMember(l,EnsureQuaternionContinuity, "EnsureQuaternionContinuity");
		addMember(l,ClearCurves, "ClearCurves");
		addMember(l,AddEvent, "AddEvent");
		addMember(l,get_length, "get_length");
		addMember(l,get_frameRate, "get_frameRate");
		addMember(l,set_frameRate, "set_frameRate");
		addMember(l,get_wrapMode, "get_wrapMode");
		addMember(l,set_wrapMode, "set_wrapMode");
		addMember(l,get_localBounds, "get_localBounds");
		addMember(l,set_localBounds, "set_localBounds");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AnimationClip),typeof(UnityEngine.Motion));
		LuaDLL.lua_pop(l, 1);
	}
}
