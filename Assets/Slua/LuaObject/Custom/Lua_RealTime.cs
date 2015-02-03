using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_RealTime : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		RealTime o;
		o=new RealTime();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		pushValue(l,RealTime.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		pushValue(l,RealTime.deltaTime);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"RealTime");
		addMember(l,"time",get_time,null,false);
		addMember(l,"deltaTime",get_deltaTime,null,false);
		createTypeMetatable(l,constructor, typeof(RealTime),typeof(UnityEngine.MonoBehaviour));
	}
}
