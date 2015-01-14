using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.AnimationInfo o = checkSelf<UnityEngine.AnimationInfo>(l);
		pushValue(l,o.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight(IntPtr l) {
		UnityEngine.AnimationInfo o = checkSelf<UnityEngine.AnimationInfo>(l);
		pushValue(l,o.weight);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationInfo");
		addMember(l,get_clip, "get_clip");
		addMember(l,get_weight, "get_weight");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AnimationInfo));
		LuaDLL.lua_pop(l, 1);
	}
}
