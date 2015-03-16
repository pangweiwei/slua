using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioLowPassFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AudioLowPassFilter o;
		o=new UnityEngine.AudioLowPassFilter();
		pushObject(l,o);
		return 1;
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
	static public int get_lowpassResonanceQ(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = (UnityEngine.AudioLowPassFilter)checkSelf(l);
		pushValue(l,o.lowpassResonanceQ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowpassResonanceQ(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = (UnityEngine.AudioLowPassFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.lowpassResonanceQ=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioLowPassFilter");
		addMember(l,"cutoffFrequency",get_cutoffFrequency,set_cutoffFrequency,true);
		addMember(l,"lowpassResonanceQ",get_lowpassResonanceQ,set_lowpassResonanceQ,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioLowPassFilter),typeof(UnityEngine.Behaviour));
	}
}
