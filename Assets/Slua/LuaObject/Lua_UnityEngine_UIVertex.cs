using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UIVertex : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Color32 v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv0(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.uv0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv0(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.uv0=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv1(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.uv1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv1(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.uv1=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tangent(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.tangent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tangent(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Vector4 v;
		checkType(l,2,out v);
		o.tangent=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simpleVert(IntPtr l) {
		pushValue(l,UnityEngine.UIVertex.simpleVert);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simpleVert(IntPtr l) {
		UnityEngine.UIVertex v;
		checkType(l,2,out v);
		UnityEngine.UIVertex.simpleVert=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UIVertex");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_normal, "get_normal");
		addMember(l,set_normal, "set_normal");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_uv0, "get_uv0");
		addMember(l,set_uv0, "set_uv0");
		addMember(l,get_uv1, "get_uv1");
		addMember(l,set_uv1, "set_uv1");
		addMember(l,get_tangent, "get_tangent");
		addMember(l,set_tangent, "set_tangent");
		addMember(l,get_simpleVert, "get_simpleVert");
		addMember(l,set_simpleVert, "set_simpleVert");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UIVertex));
		LuaDLL.lua_pop(l, 1);
	}
}
