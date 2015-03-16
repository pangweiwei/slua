using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorControllerParameter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o;
		o=new UnityEngine.AnimatorControllerParameter();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nameHash(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		pushValue(l,o.nameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		pushEnum(l,(int)o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		UnityEngine.AnimatorControllerParameterType v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultFloat(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		pushValue(l,o.defaultFloat);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultFloat(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.defaultFloat=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultInt(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		pushValue(l,o.defaultInt);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultInt(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.defaultInt=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultBool(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		pushValue(l,o.defaultBool);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultBool(IntPtr l) {
		UnityEngine.AnimatorControllerParameter o = (UnityEngine.AnimatorControllerParameter)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.defaultBool=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorControllerParameter");
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"nameHash",get_nameHash,null,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"defaultFloat",get_defaultFloat,set_defaultFloat,true);
		addMember(l,"defaultInt",get_defaultInt,set_defaultInt,true);
		addMember(l,"defaultBool",get_defaultBool,set_defaultBool,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorControllerParameter));
	}
}
