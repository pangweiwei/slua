using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AccelerationEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		UnityEngine.AccelerationEvent o = checkSelf<UnityEngine.AccelerationEvent>(l);
		pushValue(l,o.acceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		UnityEngine.AccelerationEvent o = checkSelf<UnityEngine.AccelerationEvent>(l);
		pushValue(l,o.deltaTime);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AccelerationEvent");
		addMember(l,get_acceleration, "get_acceleration");
		addMember(l,get_deltaTime, "get_deltaTime");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AccelerationEvent));
		LuaDLL.lua_pop(l, 1);
	}
}
