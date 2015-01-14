using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Shadow : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ModifyVertices(IntPtr l) {
		try{
			UnityEngine.UI.Shadow self=checkSelf<UnityEngine.UI.Shadow>(l);
			List<UnityEngine.UIVertex> a1;
			checkType(l,2,out a1);
			self.ModifyVertices(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectColor(IntPtr l) {
		UnityEngine.UI.Shadow o = checkSelf<UnityEngine.UI.Shadow>(l);
		pushValue(l,o.effectColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectColor(IntPtr l) {
		UnityEngine.UI.Shadow o = checkSelf<UnityEngine.UI.Shadow>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.effectColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectDistance(IntPtr l) {
		UnityEngine.UI.Shadow o = checkSelf<UnityEngine.UI.Shadow>(l);
		pushValue(l,o.effectDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectDistance(IntPtr l) {
		UnityEngine.UI.Shadow o = checkSelf<UnityEngine.UI.Shadow>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.effectDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGraphicAlpha(IntPtr l) {
		UnityEngine.UI.Shadow o = checkSelf<UnityEngine.UI.Shadow>(l);
		pushValue(l,o.useGraphicAlpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGraphicAlpha(IntPtr l) {
		UnityEngine.UI.Shadow o = checkSelf<UnityEngine.UI.Shadow>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.useGraphicAlpha=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Shadow");
		addMember(l,ModifyVertices, "ModifyVertices");
		addMember(l,get_effectColor, "get_effectColor");
		addMember(l,set_effectColor, "set_effectColor");
		addMember(l,get_effectDistance, "get_effectDistance");
		addMember(l,set_effectDistance, "set_effectDistance");
		addMember(l,get_useGraphicAlpha, "get_useGraphicAlpha");
		addMember(l,set_useGraphicAlpha, "set_useGraphicAlpha");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Shadow),typeof(UnityEngine.UI.BaseVertexEffect));
		LuaDLL.lua_pop(l, 1);
	}
}
