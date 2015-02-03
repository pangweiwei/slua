using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EventDelegate_Parameter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		EventDelegate.Parameter o;
		if(argc==1){
			o=new EventDelegate.Parameter();
			pushObject(l,o);
			return 1;
		}
		else if(argc==3){
			UnityEngine.Object a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			o=new EventDelegate.Parameter(a1,a2);
			pushObject(l,o);
			return 1;
		}
		else if(argc==2){
			System.Object a1;
			checkType(l,2,out a1);
			o=new EventDelegate.Parameter(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_obj(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.obj);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_obj(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		UnityEngine.Object v;
		checkType(l,2,out v);
		o.obj=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_field(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.field);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_field(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.field=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_expectedType(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.expectedType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_expectedType(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		System.Type v;
		checkType(l,2,out v);
		o.expectedType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cached(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.cached);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cached(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.cached=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_propInfo(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.propInfo);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_propInfo(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		System.Reflection.PropertyInfo v;
		checkType(l,2,out v);
		o.propInfo=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fieldInfo(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.fieldInfo);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fieldInfo(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		System.Reflection.FieldInfo v;
		checkType(l,2,out v);
		o.fieldInfo=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		System.Object v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		EventDelegate.Parameter o = (EventDelegate.Parameter)checkSelf(l);
		pushValue(l,o.type);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EventDelegate.Parameter");
		addMember(l,"obj",get_obj,set_obj,true);
		addMember(l,"field",get_field,set_field,true);
		addMember(l,"expectedType",get_expectedType,set_expectedType,true);
		addMember(l,"cached",get_cached,set_cached,true);
		addMember(l,"propInfo",get_propInfo,set_propInfo,true);
		addMember(l,"fieldInfo",get_fieldInfo,set_fieldInfo,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"type",get_type,null,true);
		createTypeMetatable(l,constructor, typeof(EventDelegate.Parameter));
	}
}
