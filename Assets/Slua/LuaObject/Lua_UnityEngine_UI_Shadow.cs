using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Shadow : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ModifyVertices(IntPtr l) {
		try{
			UnityEngine.UI.Shadow self=(UnityEngine.UI.Shadow)checkSelf(l);
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
		UnityEngine.UI.Shadow o = (UnityEngine.UI.Shadow)checkSelf(l);
		pushValue(l,o.effectColor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectColor(IntPtr l) {
		UnityEngine.UI.Shadow o = (UnityEngine.UI.Shadow)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.effectColor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_effectDistance(IntPtr l) {
		UnityEngine.UI.Shadow o = (UnityEngine.UI.Shadow)checkSelf(l);
		pushValue(l,o.effectDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_effectDistance(IntPtr l) {
		UnityEngine.UI.Shadow o = (UnityEngine.UI.Shadow)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.effectDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGraphicAlpha(IntPtr l) {
		UnityEngine.UI.Shadow o = (UnityEngine.UI.Shadow)checkSelf(l);
		pushValue(l,o.useGraphicAlpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGraphicAlpha(IntPtr l) {
		UnityEngine.UI.Shadow o = (UnityEngine.UI.Shadow)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.useGraphicAlpha=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Shadow");
		addMember(l,ModifyVertices);
		addMember(l,"effectColor",get_effectColor,set_effectColor,true);
		addMember(l,"effectDistance",get_effectDistance,set_effectDistance,true);
		addMember(l,"useGraphicAlpha",get_useGraphicAlpha,set_useGraphicAlpha,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Shadow),typeof(UnityEngine.UI.BaseVertexEffect));
	}
}
