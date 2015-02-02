using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioHighPassFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AudioHighPassFilter o;
		o=new UnityEngine.AudioHighPassFilter();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = (UnityEngine.AudioHighPassFilter)checkSelf(l);
		pushValue(l,o.cutoffFrequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = (UnityEngine.AudioHighPassFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.cutoffFrequency=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highpassResonaceQ(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = (UnityEngine.AudioHighPassFilter)checkSelf(l);
		pushValue(l,o.highpassResonaceQ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highpassResonaceQ(IntPtr l) {
		UnityEngine.AudioHighPassFilter o = (UnityEngine.AudioHighPassFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.highpassResonaceQ=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioHighPassFilter");
		addMember(l,"cutoffFrequency",get_cutoffFrequency,set_cutoffFrequency,true);
		addMember(l,"highpassResonaceQ",get_highpassResonaceQ,set_highpassResonaceQ,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioHighPassFilter),typeof(UnityEngine.Behaviour));
	}
}
