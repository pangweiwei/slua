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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		pushValue(l,o.startWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.startWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		pushValue(l,o.endWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endWidth(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.endWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autodestruct(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		pushValue(l,o.autodestruct);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autodestruct(IntPtr l) {
		UnityEngine.TrailRenderer o = (UnityEngine.TrailRenderer)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.autodestruct=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TrailRenderer");
		addMember(l,"time",get_time,set_time);
		addMember(l,"startWidth",get_startWidth,set_startWidth);
		addMember(l,"endWidth",get_endWidth,set_endWidth);
		addMember(l,"autodestruct",get_autodestruct,set_autodestruct);
		createTypeMetatable(l,constructor, typeof(UnityEngine.TrailRenderer),typeof(UnityEngine.Renderer));
	}
}
