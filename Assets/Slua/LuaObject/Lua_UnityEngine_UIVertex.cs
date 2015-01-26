using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UIVertex : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		pushValue(l,o.normal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normal(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.normal=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		UnityEngine.Color32 v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv0(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		pushValue(l,o.uv0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv0(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.uv0=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv1(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		pushValue(l,o.uv1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv1(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.uv1=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tangent(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
		pushValue(l,o.tangent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tangent(IntPtr l) {
		UnityEngine.UIVertex o = (UnityEngine.UIVertex)checkSelf(l);
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
		addMember(l,"position",get_position,set_position);
		addMember(l,"normal",get_normal,set_normal);
		addMember(l,"color",get_color,set_color);
		addMember(l,"uv0",get_uv0,set_uv0);
		addMember(l,"uv1",get_uv1,set_uv1);
		addMember(l,"tangent",get_tangent,set_tangent);
		addMember(l,"simpleVert",get_simpleVert,set_simpleVert);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UIVertex));
	}
}
