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
		UnityEngine.Touch o = (UnityEngine.Touch)checkSelf(l);
		pushValue(l,o.fingerId);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.Touch o = (UnityEngine.Touch)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawPosition(IntPtr l) {
		UnityEngine.Touch o = (UnityEngine.Touch)checkSelf(l);
		pushValue(l,o.rawPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaPosition(IntPtr l) {
		UnityEngine.Touch o = (UnityEngine.Touch)checkSelf(l);
		pushValue(l,o.deltaPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaTime(IntPtr l) {
		UnityEngine.Touch o = (UnityEngine.Touch)checkSelf(l);
		pushValue(l,o.deltaTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tapCount(IntPtr l) {
		UnityEngine.Touch o = (UnityEngine.Touch)checkSelf(l);
		pushValue(l,o.tapCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_phase(IntPtr l) {
		UnityEngine.Touch o = (UnityEngine.Touch)checkSelf(l);
		pushValue(l,o.phase);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Touch");
		addMember(l,"fingerId",get_fingerId,null);
		addMember(l,"position",get_position,null);
		addMember(l,"rawPosition",get_rawPosition,null);
		addMember(l,"deltaPosition",get_deltaPosition,null);
		addMember(l,"deltaTime",get_deltaTime,null);
		addMember(l,"tapCount",get_tapCount,null);
		addMember(l,"phase",get_phase,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Touch));
	}
}
