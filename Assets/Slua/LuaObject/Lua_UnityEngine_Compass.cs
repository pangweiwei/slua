using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Compass : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Compass o;
		if(matchType(l,1)){
			o=new UnityEngine.Compass();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_magneticHeading(IntPtr l) {
		UnityEngine.Compass o = checkSelf<UnityEngine.Compass>(l);
		pushValue(l,o.magneticHeading);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trueHeading(IntPtr l) {
		UnityEngine.Compass o = checkSelf<UnityEngine.Compass>(l);
		pushValue(l,o.trueHeading);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_headingAccuracy(IntPtr l) {
		UnityEngine.Compass o = checkSelf<UnityEngine.Compass>(l);
		pushValue(l,o.headingAccuracy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawVector(IntPtr l) {
		UnityEngine.Compass o = checkSelf<UnityEngine.Compass>(l);
		pushValue(l,o.rawVector);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timestamp(IntPtr l) {
		UnityEngine.Compass o = checkSelf<UnityEngine.Compass>(l);
		pushValue(l,o.timestamp);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Compass o = checkSelf<UnityEngine.Compass>(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Compass o = checkSelf<UnityEngine.Compass>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Compass");
		addMember(l,get_magneticHeading, "get_magneticHeading");
		addMember(l,get_trueHeading, "get_trueHeading");
		addMember(l,get_headingAccuracy, "get_headingAccuracy");
		addMember(l,get_rawVector, "get_rawVector");
		addMember(l,get_timestamp, "get_timestamp");
		addMember(l,get_enabled, "get_enabled");
		addMember(l,set_enabled, "set_enabled");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Compass));
		LuaDLL.lua_pop(l, 1);
	}
}
