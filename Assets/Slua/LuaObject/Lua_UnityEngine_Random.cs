﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Random : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Random o;
		o=new UnityEngine.Random();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Range_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single ret=UnityEngine.Random.Range(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 ret=UnityEngine.Random.Range(a1,a2);
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
	static public int get_seed(IntPtr l) {
		pushValue(l,UnityEngine.Random.seed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_seed(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.Random.seed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		pushValue(l,UnityEngine.Random.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_insideUnitSphere(IntPtr l) {
		pushValue(l,UnityEngine.Random.insideUnitSphere);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_insideUnitCircle(IntPtr l) {
		pushValue(l,UnityEngine.Random.insideUnitCircle);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onUnitSphere(IntPtr l) {
		pushValue(l,UnityEngine.Random.onUnitSphere);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		pushValue(l,UnityEngine.Random.rotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotationUniform(IntPtr l) {
		pushValue(l,UnityEngine.Random.rotationUniform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Random");
		addMember(l,Range_s);
		addMember(l,"seed",get_seed,set_seed,false);
		addMember(l,"value",get_value,null,false);
		addMember(l,"insideUnitSphere",get_insideUnitSphere,null,false);
		addMember(l,"insideUnitCircle",get_insideUnitCircle,null,false);
		addMember(l,"onUnitSphere",get_onUnitSphere,null,false);
		addMember(l,"rotation",get_rotation,null,false);
		addMember(l,"rotationUniform",get_rotationUniform,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Random));
	}
}
