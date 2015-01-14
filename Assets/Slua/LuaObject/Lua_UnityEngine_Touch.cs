using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Touch : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fingerId(IntPtr l) {
		UnityEngine.Touch o = checkSelf<UnityEngine.Touch>(l);
		pushValue(l,o.fingerId);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Touch o = checkSelf<UnityEngine.Touch>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawPosition(IntPtr l) {
		UnityEngine.Touch o = checkSelf<UnityEngine.Touch>(l);
		pushValue(l,o.rawPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaPosition(IntPtr l) {
		UnityEngine.Touch o = checkSelf<UnityEngine.Touch>(l);
		pushValue(l,o.deltaPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		UnityEngine.Touch o = checkSelf<UnityEngine.Touch>(l);
		pushValue(l,o.deltaTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tapCount(IntPtr l) {
		UnityEngine.Touch o = checkSelf<UnityEngine.Touch>(l);
		pushValue(l,o.tapCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_phase(IntPtr l) {
		UnityEngine.Touch o = checkSelf<UnityEngine.Touch>(l);
		pushValue(l,o.phase);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Touch");
		addMember(l,get_fingerId, "get_fingerId");
		addMember(l,get_position, "get_position");
		addMember(l,get_rawPosition, "get_rawPosition");
		addMember(l,get_deltaPosition, "get_deltaPosition");
		addMember(l,get_deltaTime, "get_deltaTime");
		addMember(l,get_tapCount, "get_tapCount");
		addMember(l,get_phase, "get_phase");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Touch));
		LuaDLL.lua_pop(l, 1);
	}
}
