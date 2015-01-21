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
			UnityEngine.CrashReport self=(UnityEngine.CrashReport)checkSelf(l);
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
		UnityEngine.CrashReport o = (UnityEngine.CrashReport)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.CrashReport o = (UnityEngine.CrashReport)checkSelf(l);
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
		addMember(l,RemoveAll);
		addMember(l,Remove);
		addMember(l,"time",get_time,null);
		addMember(l,"text",get_text,null);
		addMember(l,"reports",get_reports,null);
		addMember(l,"lastReport",get_lastReport,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CrashReport));
	}
}
