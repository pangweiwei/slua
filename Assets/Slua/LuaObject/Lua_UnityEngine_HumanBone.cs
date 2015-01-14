using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanBone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_limit(IntPtr l) {
		UnityEngine.HumanBone o = checkSelf<UnityEngine.HumanBone>(l);
		pushValue(l,o.limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limit(IntPtr l) {
		UnityEngine.HumanBone o = checkSelf<UnityEngine.HumanBone>(l);
		UnityEngine.HumanLimit v;
		checkType(l,2,out v);
		o.limit=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneName(IntPtr l) {
		UnityEngine.HumanBone o = checkSelf<UnityEngine.HumanBone>(l);
		pushValue(l,o.boneName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneName(IntPtr l) {
		UnityEngine.HumanBone o = checkSelf<UnityEngine.HumanBone>(l);
		System.String v;
		checkType(l,2,out v);
		o.boneName=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_humanName(IntPtr l) {
		UnityEngine.HumanBone o = checkSelf<UnityEngine.HumanBone>(l);
		pushValue(l,o.humanName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_humanName(IntPtr l) {
		UnityEngine.HumanBone o = checkSelf<UnityEngine.HumanBone>(l);
		System.String v;
		checkType(l,2,out v);
		o.humanName=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanBone");
		addMember(l,get_limit, "get_limit");
		addMember(l,set_limit, "set_limit");
		addMember(l,get_boneName, "get_boneName");
		addMember(l,set_boneName, "set_boneName");
		addMember(l,get_humanName, "get_humanName");
		addMember(l,set_humanName, "set_humanName");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.HumanBone));
		LuaDLL.lua_pop(l, 1);
	}
}
