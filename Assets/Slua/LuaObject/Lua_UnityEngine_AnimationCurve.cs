using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationCurve : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AnimationCurve o;
		if(matchType(l,1,typeof(UnityEngine.Keyframe))){
			UnityEngine.Keyframe[] a1;
			checkType(l,1,out a1);
			o=new UnityEngine.AnimationCurve(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1)){
			o=new UnityEngine.AnimationCurve();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Evaluate(IntPtr l) {
		try{
			UnityEngine.AnimationCurve self=(UnityEngine.AnimationCurve)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single ret=self.Evaluate(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddKey(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Single),typeof(System.Single))){
				UnityEngine.AnimationCurve self=(UnityEngine.AnimationCurve)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 ret=self.AddKey(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(UnityEngine.Keyframe))){
				UnityEngine.AnimationCurve self=(UnityEngine.AnimationCurve)checkSelf(l);
				UnityEngine.Keyframe a1;
				checkType(l,2,out a1);
				System.Int32 ret=self.AddKey(a1);
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
	static public int MoveKey(IntPtr l) {
		try{
			UnityEngine.AnimationCurve self=(UnityEngine.AnimationCurve)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Keyframe a2;
			checkType(l,3,out a2);
			System.Int32 ret=self.MoveKey(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveKey(IntPtr l) {
		try{
			UnityEngine.AnimationCurve self=(UnityEngine.AnimationCurve)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveKey(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SmoothTangents(IntPtr l) {
		try{
			UnityEngine.AnimationCurve self=(UnityEngine.AnimationCurve)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SmoothTangents(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Linear_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.AnimationCurve ret=UnityEngine.AnimationCurve.Linear(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EaseInOut_s(IntPtr l) {
		try{
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			UnityEngine.AnimationCurve ret=UnityEngine.AnimationCurve.EaseInOut(a1,a2,a3,a4);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keys(IntPtr l) {
		UnityEngine.AnimationCurve o = (UnityEngine.AnimationCurve)checkSelf(l);
		pushValue(l,o.keys);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keys(IntPtr l) {
		UnityEngine.AnimationCurve o = (UnityEngine.AnimationCurve)checkSelf(l);
		UnityEngine.Keyframe[] v;
		checkType(l,2,out v);
		o.keys=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		UnityEngine.AnimationCurve o = (UnityEngine.AnimationCurve)checkSelf(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preWrapMode(IntPtr l) {
		UnityEngine.AnimationCurve o = (UnityEngine.AnimationCurve)checkSelf(l);
		pushValue(l,o.preWrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preWrapMode(IntPtr l) {
		UnityEngine.AnimationCurve o = (UnityEngine.AnimationCurve)checkSelf(l);
		UnityEngine.WrapMode v;
		checkEnum(l,2,out v);
		o.preWrapMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_postWrapMode(IntPtr l) {
		UnityEngine.AnimationCurve o = (UnityEngine.AnimationCurve)checkSelf(l);
		pushValue(l,o.postWrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_postWrapMode(IntPtr l) {
		UnityEngine.AnimationCurve o = (UnityEngine.AnimationCurve)checkSelf(l);
		UnityEngine.WrapMode v;
		checkEnum(l,2,out v);
		o.postWrapMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationCurve");
		addMember(l,Evaluate);
		addMember(l,AddKey);
		addMember(l,MoveKey);
		addMember(l,RemoveKey);
		addMember(l,SmoothTangents);
		addMember(l,Linear_s);
		addMember(l,EaseInOut_s);
		addMember(l,"keys",get_keys,set_keys,true);
		addMember(l,"length",get_length,null,true);
		addMember(l,"preWrapMode",get_preWrapMode,set_preWrapMode,true);
		addMember(l,"postWrapMode",get_postWrapMode,set_postWrapMode,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimationCurve));
	}
}
