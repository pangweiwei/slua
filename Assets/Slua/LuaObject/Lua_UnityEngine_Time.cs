using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Time : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Time o;
		if(matchType(l,1)){
			o=new UnityEngine.Time();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		pushValue(l,UnityEngine.Time.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeSinceLevelLoad(IntPtr l) {
		pushValue(l,UnityEngine.Time.timeSinceLevelLoad);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		pushValue(l,UnityEngine.Time.deltaTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fixedTime(IntPtr l) {
		pushValue(l,UnityEngine.Time.fixedTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_unscaledTime(IntPtr l) {
		pushValue(l,UnityEngine.Time.unscaledTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_unscaledDeltaTime(IntPtr l) {
		pushValue(l,UnityEngine.Time.unscaledDeltaTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fixedDeltaTime(IntPtr l) {
		pushValue(l,UnityEngine.Time.fixedDeltaTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fixedDeltaTime(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Time.fixedDeltaTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumDeltaTime(IntPtr l) {
		pushValue(l,UnityEngine.Time.maximumDeltaTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumDeltaTime(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Time.maximumDeltaTime=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_smoothDeltaTime(IntPtr l) {
		pushValue(l,UnityEngine.Time.smoothDeltaTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeScale(IntPtr l) {
		pushValue(l,UnityEngine.Time.timeScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_timeScale(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Time.timeScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frameCount(IntPtr l) {
		pushValue(l,UnityEngine.Time.frameCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderedFrameCount(IntPtr l) {
		pushValue(l,UnityEngine.Time.renderedFrameCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_realtimeSinceStartup(IntPtr l) {
		pushValue(l,UnityEngine.Time.realtimeSinceStartup);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_captureFramerate(IntPtr l) {
		pushValue(l,UnityEngine.Time.captureFramerate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_captureFramerate(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.Time.captureFramerate=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Time");
		addMember(l,get_time, "get_time");
		addMember(l,get_timeSinceLevelLoad, "get_timeSinceLevelLoad");
		addMember(l,get_deltaTime, "get_deltaTime");
		addMember(l,get_fixedTime, "get_fixedTime");
		addMember(l,get_unscaledTime, "get_unscaledTime");
		addMember(l,get_unscaledDeltaTime, "get_unscaledDeltaTime");
		addMember(l,get_fixedDeltaTime, "get_fixedDeltaTime");
		addMember(l,set_fixedDeltaTime, "set_fixedDeltaTime");
		addMember(l,get_maximumDeltaTime, "get_maximumDeltaTime");
		addMember(l,set_maximumDeltaTime, "set_maximumDeltaTime");
		addMember(l,get_smoothDeltaTime, "get_smoothDeltaTime");
		addMember(l,get_timeScale, "get_timeScale");
		addMember(l,set_timeScale, "set_timeScale");
		addMember(l,get_frameCount, "get_frameCount");
		addMember(l,get_renderedFrameCount, "get_renderedFrameCount");
		addMember(l,get_realtimeSinceStartup, "get_realtimeSinceStartup");
		addMember(l,get_captureFramerate, "get_captureFramerate");
		addMember(l,set_captureFramerate, "set_captureFramerate");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Time));
		LuaDLL.lua_pop(l, 1);
	}
}
