using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AccelerationEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		UnityEngine.AccelerationEvent o = (UnityEngine.AccelerationEvent)checkSelf(l);
		pushValue(l,o.acceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		UnityEngine.AccelerationEvent o = (UnityEngine.AccelerationEvent)checkSelf(l);
		pushValue(l,o.deltaTime);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AccelerationEvent");
		addMember(l,"acceleration",get_acceleration,null,true);
		addMember(l,"deltaTime",get_deltaTime,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AccelerationEvent));
	}
}
