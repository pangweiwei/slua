using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Time : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Time o;
		o=new UnityEngine.Time();
		pushObject(l,o);
		return 1;
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
		float v;
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
		float v;
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
		float v;
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
		int v;
		checkType(l,2,out v);
		UnityEngine.Time.captureFramerate=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Time");
		addMember(l,"time",get_time,null,false);
		addMember(l,"timeSinceLevelLoad",get_timeSinceLevelLoad,null,false);
		addMember(l,"deltaTime",get_deltaTime,null,false);
		addMember(l,"fixedTime",get_fixedTime,null,false);
		addMember(l,"unscaledTime",get_unscaledTime,null,false);
		addMember(l,"unscaledDeltaTime",get_unscaledDeltaTime,null,false);
		addMember(l,"fixedDeltaTime",get_fixedDeltaTime,set_fixedDeltaTime,false);
		addMember(l,"maximumDeltaTime",get_maximumDeltaTime,set_maximumDeltaTime,false);
		addMember(l,"smoothDeltaTime",get_smoothDeltaTime,null,false);
		addMember(l,"timeScale",get_timeScale,set_timeScale,false);
		addMember(l,"frameCount",get_frameCount,null,false);
		addMember(l,"renderedFrameCount",get_renderedFrameCount,null,false);
		addMember(l,"realtimeSinceStartup",get_realtimeSinceStartup,null,false);
		addMember(l,"captureFramerate",get_captureFramerate,set_captureFramerate,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Time));
	}
}
