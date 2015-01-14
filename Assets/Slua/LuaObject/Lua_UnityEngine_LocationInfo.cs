using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LocationInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_latitude(IntPtr l) {
		UnityEngine.LocationInfo o = checkSelf<UnityEngine.LocationInfo>(l);
		pushValue(l,o.latitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_longitude(IntPtr l) {
		UnityEngine.LocationInfo o = checkSelf<UnityEngine.LocationInfo>(l);
		pushValue(l,o.longitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_altitude(IntPtr l) {
		UnityEngine.LocationInfo o = checkSelf<UnityEngine.LocationInfo>(l);
		pushValue(l,o.altitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalAccuracy(IntPtr l) {
		UnityEngine.LocationInfo o = checkSelf<UnityEngine.LocationInfo>(l);
		pushValue(l,o.horizontalAccuracy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAccuracy(IntPtr l) {
		UnityEngine.LocationInfo o = checkSelf<UnityEngine.LocationInfo>(l);
		pushValue(l,o.verticalAccuracy);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timestamp(IntPtr l) {
		UnityEngine.LocationInfo o = checkSelf<UnityEngine.LocationInfo>(l);
		pushValue(l,o.timestamp);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LocationInfo");
		addMember(l,get_latitude, "get_latitude");
		addMember(l,get_longitude, "get_longitude");
		addMember(l,get_altitude, "get_altitude");
		addMember(l,get_horizontalAccuracy, "get_horizontalAccuracy");
		addMember(l,get_verticalAccuracy, "get_verticalAccuracy");
		addMember(l,get_timestamp, "get_timestamp");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LocationInfo));
		LuaDLL.lua_pop(l, 1);
	}
}
