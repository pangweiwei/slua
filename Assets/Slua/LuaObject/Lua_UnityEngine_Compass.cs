using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Compass : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Compass o;
		o=new UnityEngine.Compass();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_magneticHeading(IntPtr l) {
		UnityEngine.Compass o = (UnityEngine.Compass)checkSelf(l);
		pushValue(l,o.magneticHeading);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trueHeading(IntPtr l) {
		UnityEngine.Compass o = (UnityEngine.Compass)checkSelf(l);
		pushValue(l,o.trueHeading);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_headingAccuracy(IntPtr l) {
		UnityEngine.Compass o = (UnityEngine.Compass)checkSelf(l);
		pushValue(l,o.headingAccuracy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawVector(IntPtr l) {
		UnityEngine.Compass o = (UnityEngine.Compass)checkSelf(l);
		pushValue(l,o.rawVector);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timestamp(IntPtr l) {
		UnityEngine.Compass o = (UnityEngine.Compass)checkSelf(l);
		pushValue(l,o.timestamp);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.Compass o = (UnityEngine.Compass)checkSelf(l);
		pushValue(l,o.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.Compass o = (UnityEngine.Compass)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.enabled=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Compass");
		addMember(l,"magneticHeading",get_magneticHeading,null,true);
		addMember(l,"trueHeading",get_trueHeading,null,true);
		addMember(l,"headingAccuracy",get_headingAccuracy,null,true);
		addMember(l,"rawVector",get_rawVector,null,true);
		addMember(l,"timestamp",get_timestamp,null,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Compass));
	}
}
