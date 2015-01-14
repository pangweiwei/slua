using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CrashReport : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveAll(IntPtr l) {
		try{
			UnityEngine.CrashReport.RemoveAll();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Remove(IntPtr l) {
		try{
			UnityEngine.CrashReport self=checkSelf<UnityEngine.CrashReport>(l);
			self.Remove();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.CrashReport o = checkSelf<UnityEngine.CrashReport>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.CrashReport o = checkSelf<UnityEngine.CrashReport>(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reports(IntPtr l) {
		pushValue(l,UnityEngine.CrashReport.reports);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastReport(IntPtr l) {
		pushValue(l,UnityEngine.CrashReport.lastReport);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CrashReport");
		addMember(l,RemoveAll, "RemoveAll");
		addMember(l,Remove, "Remove");
		addMember(l,get_time, "get_time");
		addMember(l,get_text, "get_text");
		addMember(l,get_reports, "get_reports");
		addMember(l,get_lastReport, "get_lastReport");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.CrashReport));
		LuaDLL.lua_pop(l, 1);
	}
}
