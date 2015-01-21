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
		UnityEngine.HumanBone o = (UnityEngine.HumanBone)checkSelf(l);
		pushValue(l,o.limit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_limit(IntPtr l) {
		UnityEngine.HumanBone o = (UnityEngine.HumanBone)checkSelf(l);
		UnityEngine.HumanLimit v;
		checkType(l,2,out v);
		o.limit=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneName(IntPtr l) {
		UnityEngine.HumanBone o = (UnityEngine.HumanBone)checkSelf(l);
		pushValue(l,o.boneName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneName(IntPtr l) {
		UnityEngine.HumanBone o = (UnityEngine.HumanBone)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.boneName=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_humanName(IntPtr l) {
		UnityEngine.HumanBone o = (UnityEngine.HumanBone)checkSelf(l);
		pushValue(l,o.humanName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_humanName(IntPtr l) {
		UnityEngine.HumanBone o = (UnityEngine.HumanBone)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.humanName=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanBone");
		addMember(l,"limit",get_limit,set_limit);
		addMember(l,"boneName",get_boneName,set_boneName);
		addMember(l,"humanName",get_humanName,set_humanName);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HumanBone));
	}
}
