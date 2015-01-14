using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Profiler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Profiler o;
		if(matchType(l,1)){
			o=new UnityEngine.Profiler();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddFramesFromFile(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Profiler.AddFramesFromFile(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BeginSample(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Profiler.BeginSample(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(System.String),typeof(UnityEngine.Object))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Profiler.BeginSample(a1,a2);
				return 0;
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
	static public int EndSample(IntPtr l) {
		try{
			UnityEngine.Profiler.EndSample();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRuntimeMemorySize(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.Int32 ret=UnityEngine.Profiler.GetRuntimeMemorySize(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMonoHeapSize(IntPtr l) {
		try{
			System.UInt32 ret=UnityEngine.Profiler.GetMonoHeapSize();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMonoUsedSize(IntPtr l) {
		try{
			System.UInt32 ret=UnityEngine.Profiler.GetMonoUsedSize();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTotalAllocatedMemory(IntPtr l) {
		try{
			System.UInt32 ret=UnityEngine.Profiler.GetTotalAllocatedMemory();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTotalUnusedReservedMemory(IntPtr l) {
		try{
			System.UInt32 ret=UnityEngine.Profiler.GetTotalUnusedReservedMemory();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTotalReservedMemory(IntPtr l) {
		try{
			System.UInt32 ret=UnityEngine.Profiler.GetTotalReservedMemory();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_supported(IntPtr l) {
		pushValue(l,UnityEngine.Profiler.supported);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_logFile(IntPtr l) {
		pushValue(l,UnityEngine.Profiler.logFile);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_logFile(IntPtr l) {
		System.String v;
		checkType(l,2,out v);
		UnityEngine.Profiler.logFile=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableBinaryLog(IntPtr l) {
		pushValue(l,UnityEngine.Profiler.enableBinaryLog);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableBinaryLog(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Profiler.enableBinaryLog=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		pushValue(l,UnityEngine.Profiler.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Profiler.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_usedHeapSize(IntPtr l) {
		pushValue(l,UnityEngine.Profiler.usedHeapSize);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Profiler");
		addMember(l,AddFramesFromFile, "AddFramesFromFile");
		addMember(l,BeginSample, "BeginSample");
		addMember(l,EndSample, "EndSample");
		addMember(l,GetRuntimeMemorySize, "GetRuntimeMemorySize");
		addMember(l,GetMonoHeapSize, "GetMonoHeapSize");
		addMember(l,GetMonoUsedSize, "GetMonoUsedSize");
		addMember(l,GetTotalAllocatedMemory, "GetTotalAllocatedMemory");
		addMember(l,GetTotalUnusedReservedMemory, "GetTotalUnusedReservedMemory");
		addMember(l,GetTotalReservedMemory, "GetTotalReservedMemory");
		addMember(l,get_supported, "get_supported");
		addMember(l,get_logFile, "get_logFile");
		addMember(l,set_logFile, "set_logFile");
		addMember(l,get_enableBinaryLog, "get_enableBinaryLog");
		addMember(l,set_enableBinaryLog, "set_enableBinaryLog");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		addMember(l,get_usedHeapSize, "get_usedHeapSize");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Profiler));
		LuaDLL.lua_pop(l, 1);
	}
}
