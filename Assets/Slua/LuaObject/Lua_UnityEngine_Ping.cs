﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Ping : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Ping o;
		System.String a1;
		checkType(l,2,out a1);
		o=new UnityEngine.Ping(a1);
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DestroyPing(IntPtr l) {
		try{
			UnityEngine.Ping self=(UnityEngine.Ping)checkSelf(l);
			self.DestroyPing();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDone(IntPtr l) {
		UnityEngine.Ping o = (UnityEngine.Ping)checkSelf(l);
		pushValue(l,o.isDone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.Ping o = (UnityEngine.Ping)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ip(IntPtr l) {
		UnityEngine.Ping o = (UnityEngine.Ping)checkSelf(l);
		pushValue(l,o.ip);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Ping");
		addMember(l,DestroyPing);
		addMember(l,"isDone",get_isDone,null,true);
		addMember(l,"time",get_time,null,true);
		addMember(l,"ip",get_ip,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Ping));
	}
}
