﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_StackTraceUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.StackTraceUtility o;
		o=new UnityEngine.StackTraceUtility();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ExtractStackTrace_s(IntPtr l) {
		try{
			System.String ret=UnityEngine.StackTraceUtility.ExtractStackTrace();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ExtractStringFromException_s(IntPtr l) {
		try{
			System.Object a1;
			checkType(l,1,out a1);
			System.String ret=UnityEngine.StackTraceUtility.ExtractStringFromException(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.StackTraceUtility");
		addMember(l,ExtractStackTrace_s);
		addMember(l,ExtractStringFromException_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.StackTraceUtility));
	}
}
