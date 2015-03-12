using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LocationInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_latitude(IntPtr l) {
		UnityEngine.LocationInfo o = (UnityEngine.LocationInfo)checkSelf(l);
		pushValue(l,o.latitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_longitude(IntPtr l) {
		UnityEngine.LocationInfo o = (UnityEngine.LocationInfo)checkSelf(l);
		pushValue(l,o.longitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_altitude(IntPtr l) {
		UnityEngine.LocationInfo o = (UnityEngine.LocationInfo)checkSelf(l);
		pushValue(l,o.altitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalAccuracy(IntPtr l) {
		UnityEngine.LocationInfo o = (UnityEngine.LocationInfo)checkSelf(l);
		pushValue(l,o.horizontalAccuracy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAccuracy(IntPtr l) {
		UnityEngine.LocationInfo o = (UnityEngine.LocationInfo)checkSelf(l);
		pushValue(l,o.verticalAccuracy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timestamp(IntPtr l) {
		UnityEngine.LocationInfo o = (UnityEngine.LocationInfo)checkSelf(l);
		pushValue(l,o.timestamp);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LocationInfo");
		addMember(l,"latitude",get_latitude,null,true);
		addMember(l,"longitude",get_longitude,null,true);
		addMember(l,"altitude",get_altitude,null,true);
		addMember(l,"horizontalAccuracy",get_horizontalAccuracy,null,true);
		addMember(l,"verticalAccuracy",get_verticalAccuracy,null,true);
		addMember(l,"timestamp",get_timestamp,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LocationInfo));
	}
}
