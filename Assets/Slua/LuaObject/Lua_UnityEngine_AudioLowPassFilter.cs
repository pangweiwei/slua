using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioLowPassFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioLowPassFilter o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioLowPassFilter();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = (UnityEngine.AudioLowPassFilter)checkSelf(l);
		pushValue(l,o.cutoffFrequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = (UnityEngine.AudioLowPassFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.cutoffFrequency=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowpassResonaceQ(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = (UnityEngine.AudioLowPassFilter)checkSelf(l);
		pushValue(l,o.lowpassResonaceQ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowpassResonaceQ(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = (UnityEngine.AudioLowPassFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lowpassResonaceQ=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioLowPassFilter");
		addMember(l,"cutoffFrequency",get_cutoffFrequency,set_cutoffFrequency,true);
		addMember(l,"lowpassResonaceQ",get_lowpassResonaceQ,set_lowpassResonaceQ,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioLowPassFilter),typeof(UnityEngine.Behaviour));
	}
}
