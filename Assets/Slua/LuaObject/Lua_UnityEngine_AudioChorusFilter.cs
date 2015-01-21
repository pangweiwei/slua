using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioChorusFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioChorusFilter o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioChorusFilter();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dryMix(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		pushValue(l,o.dryMix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dryMix(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.dryMix=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wetMix1(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		pushValue(l,o.wetMix1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wetMix1(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.wetMix1=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wetMix2(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		pushValue(l,o.wetMix2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wetMix2(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.wetMix2=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wetMix3(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		pushValue(l,o.wetMix3);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wetMix3(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.wetMix3=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delay(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		pushValue(l,o.delay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delay(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.delay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rate(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		pushValue(l,o.rate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rate(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.rate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UnityEngine.AudioChorusFilter o = (UnityEngine.AudioChorusFilter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.depth=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioChorusFilter");
		addMember(l,"dryMix",get_dryMix,set_dryMix);
		addMember(l,"wetMix1",get_wetMix1,set_wetMix1);
		addMember(l,"wetMix2",get_wetMix2,set_wetMix2);
		addMember(l,"wetMix3",get_wetMix3,set_wetMix3);
		addMember(l,"delay",get_delay,set_delay);
		addMember(l,"rate",get_rate,set_rate);
		addMember(l,"depth",get_depth,set_depth);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioChorusFilter),typeof(UnityEngine.Behaviour));
	}
}
