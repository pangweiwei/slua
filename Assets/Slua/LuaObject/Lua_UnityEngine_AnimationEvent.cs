using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AnimationEvent o;
		if(matchType(l,1)){
			o=new UnityEngine.AnimationEvent();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stringParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.stringParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stringParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		System.String v;
		checkType(l,2,out v);
		o.stringParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_floatParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.floatParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_floatParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.floatParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.intParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.intParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_objectReferenceParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.objectReferenceParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_objectReferenceParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		UnityEngine.Object v;
		checkType(l,2,out v);
		o.objectReferenceParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_functionName(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.functionName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_functionName(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		System.String v;
		checkType(l,2,out v);
		o.functionName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_messageOptions(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.messageOptions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_messageOptions(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		UnityEngine.SendMessageOptions v;
		checkEnum(l,2,out v);
		o.messageOptions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animationState(IntPtr l) {
		UnityEngine.AnimationEvent o = checkSelf<UnityEngine.AnimationEvent>(l);
		pushValue(l,o.animationState);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationEvent");
		addMember(l,get_stringParameter, "get_stringParameter");
		addMember(l,set_stringParameter, "set_stringParameter");
		addMember(l,get_floatParameter, "get_floatParameter");
		addMember(l,set_floatParameter, "set_floatParameter");
		addMember(l,get_intParameter, "get_intParameter");
		addMember(l,set_intParameter, "set_intParameter");
		addMember(l,get_objectReferenceParameter, "get_objectReferenceParameter");
		addMember(l,set_objectReferenceParameter, "set_objectReferenceParameter");
		addMember(l,get_functionName, "get_functionName");
		addMember(l,set_functionName, "set_functionName");
		addMember(l,get_time, "get_time");
		addMember(l,set_time, "set_time");
		addMember(l,get_messageOptions, "get_messageOptions");
		addMember(l,set_messageOptions, "set_messageOptions");
		addMember(l,get_animationState, "get_animationState");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AnimationEvent));
		LuaDLL.lua_pop(l, 1);
	}
}
