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
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.stringParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stringParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.stringParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_floatParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.floatParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_floatParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.floatParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.intParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.intParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_objectReferenceParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.objectReferenceParameter);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_objectReferenceParameter(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		UnityEngine.Object v;
		checkType(l,2,out v);
		o.objectReferenceParameter=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_functionName(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.functionName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_functionName(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.functionName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_messageOptions(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.messageOptions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_messageOptions(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		UnityEngine.SendMessageOptions v;
		checkEnum(l,2,out v);
		o.messageOptions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animationState(IntPtr l) {
		UnityEngine.AnimationEvent o = (UnityEngine.AnimationEvent)checkSelf(l);
		pushValue(l,o.animationState);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationEvent");
		addMember(l,"stringParameter",get_stringParameter,set_stringParameter);
		addMember(l,"floatParameter",get_floatParameter,set_floatParameter);
		addMember(l,"intParameter",get_intParameter,set_intParameter);
		addMember(l,"objectReferenceParameter",get_objectReferenceParameter,set_objectReferenceParameter);
		addMember(l,"functionName",get_functionName,set_functionName);
		addMember(l,"time",get_time,set_time);
		addMember(l,"messageOptions",get_messageOptions,set_messageOptions);
		addMember(l,"animationState",get_animationState,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimationEvent));
	}
}
