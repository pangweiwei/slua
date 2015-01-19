using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralPropertyDescription : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ProceduralPropertyDescription o;
		if(matchType(l,1)){
			o=new UnityEngine.ProceduralPropertyDescription();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.String v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_label(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.label);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_label(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.String v;
		checkType(l,2,out v);
		o.label=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_group(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.group);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_group(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.String v;
		checkType(l,2,out v);
		o.group=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.type);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		UnityEngine.ProceduralPropertyType v;
		checkEnum(l,2,out v);
		o.type=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasRange(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.hasRange);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasRange(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.hasRange=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minimum(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.minimum);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minimum(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minimum=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximum(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.maximum);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximum(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maximum=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_step(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.step);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_step(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.Single v;
		checkType(l,2,out v);
		o.step=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enumOptions(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.enumOptions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enumOptions(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.String[] v;
		checkType(l,2,out v);
		o.enumOptions=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_componentLabels(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		pushValue(l,o.componentLabels);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_componentLabels(IntPtr l) {
		UnityEngine.ProceduralPropertyDescription o = checkSelf<UnityEngine.ProceduralPropertyDescription>(l);
		System.String[] v;
		checkType(l,2,out v);
		o.componentLabels=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ProceduralPropertyDescription");
		addMember(l,get_name, "get_name");
		addMember(l,set_name, "set_name");
		addMember(l,get_label, "get_label");
		addMember(l,set_label, "set_label");
		addMember(l,get_group, "get_group");
		addMember(l,set_group, "set_group");
		addMember(l,get_type, "get_type");
		addMember(l,set_type, "set_type");
		addMember(l,get_hasRange, "get_hasRange");
		addMember(l,set_hasRange, "set_hasRange");
		addMember(l,get_minimum, "get_minimum");
		addMember(l,set_minimum, "set_minimum");
		addMember(l,get_maximum, "get_maximum");
		addMember(l,set_maximum, "set_maximum");
		addMember(l,get_step, "get_step");
		addMember(l,set_step, "set_step");
		addMember(l,get_enumOptions, "get_enumOptions");
		addMember(l,set_enumOptions, "set_enumOptions");
		addMember(l,get_componentLabels, "get_componentLabels");
		addMember(l,set_componentLabels, "set_componentLabels");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ProceduralPropertyDescription));
		LuaDLL.lua_pop(l, 1);
	}
}
