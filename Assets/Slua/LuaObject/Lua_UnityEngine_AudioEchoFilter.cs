using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioEchoFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioEchoFilter o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioEchoFilter();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delay(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		pushValue(l,o.delay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delay(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.delay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayRatio(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		pushValue(l,o.decayRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayRatio(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.decayRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dryMix(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		pushValue(l,o.dryMix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dryMix(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.dryMix=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wetMix(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		pushValue(l,o.wetMix);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wetMix(IntPtr l) {
		UnityEngine.AudioEchoFilter o = checkSelf<UnityEngine.AudioEchoFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.wetMix=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioEchoFilter");
		addMember(l,get_delay, "get_delay");
		addMember(l,set_delay, "set_delay");
		addMember(l,get_decayRatio, "get_decayRatio");
		addMember(l,set_decayRatio, "set_decayRatio");
		addMember(l,get_dryMix, "get_dryMix");
		addMember(l,set_dryMix, "set_dryMix");
		addMember(l,get_wetMix, "get_wetMix");
		addMember(l,set_wetMix, "set_wetMix");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioEchoFilter),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
