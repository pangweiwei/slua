using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TrailRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.TrailRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.TrailRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		pushValue(l,o.startWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.startWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		pushValue(l,o.endWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		System.Single v;
		checkType(l,2,out v);
		o.endWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autodestruct(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		pushValue(l,o.autodestruct);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autodestruct(IntPtr l) {
		UnityEngine.TrailRenderer o = checkSelf<UnityEngine.TrailRenderer>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.autodestruct=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TrailRenderer");
		addMember(l,get_time, "get_time");
		addMember(l,set_time, "set_time");
		addMember(l,get_startWidth, "get_startWidth");
		addMember(l,set_startWidth, "set_startWidth");
		addMember(l,get_endWidth, "get_endWidth");
		addMember(l,set_endWidth, "set_endWidth");
		addMember(l,get_autodestruct, "get_autodestruct");
		addMember(l,set_autodestruct, "set_autodestruct");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.TrailRenderer),typeof(UnityEngine.Renderer));
		LuaDLL.lua_pop(l, 1);
	}
}
