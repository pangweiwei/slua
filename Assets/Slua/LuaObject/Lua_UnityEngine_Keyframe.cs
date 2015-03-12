﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Keyframe : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.Keyframe o;
		if(argc==3){
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			o=new UnityEngine.Keyframe(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(argc==5){
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			o=new UnityEngine.Keyframe(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.time=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.value=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inTangent(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		pushValue(l,o.inTangent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inTangent(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.inTangent=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_outTangent(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		pushValue(l,o.outTangent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_outTangent(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.outTangent=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tangentMode(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		pushValue(l,o.tangentMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tangentMode(IntPtr l) {
		UnityEngine.Keyframe o = (UnityEngine.Keyframe)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.tangentMode=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Keyframe");
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"inTangent",get_inTangent,set_inTangent,true);
		addMember(l,"outTangent",get_outTangent,set_outTangent,true);
		addMember(l,"tangentMode",get_tangentMode,set_tangentMode,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Keyframe));
	}
}
