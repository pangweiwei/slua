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
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = checkSelf<UnityEngine.AudioLowPassFilter>(l);
		pushValue(l,o.cutoffFrequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cutoffFrequency(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = checkSelf<UnityEngine.AudioLowPassFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.cutoffFrequency=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowpassResonaceQ(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = checkSelf<UnityEngine.AudioLowPassFilter>(l);
		pushValue(l,o.lowpassResonaceQ);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowpassResonaceQ(IntPtr l) {
		UnityEngine.AudioLowPassFilter o = checkSelf<UnityEngine.AudioLowPassFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.lowpassResonaceQ=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioLowPassFilter");
		addMember(l,get_cutoffFrequency, "get_cutoffFrequency");
		addMember(l,set_cutoffFrequency, "set_cutoffFrequency");
		addMember(l,get_lowpassResonaceQ, "get_lowpassResonaceQ");
		addMember(l,set_lowpassResonaceQ, "set_lowpassResonaceQ");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioLowPassFilter),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
