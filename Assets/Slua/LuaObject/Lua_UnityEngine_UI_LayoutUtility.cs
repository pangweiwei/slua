using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_LayoutUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMinSize(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetMinSize(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPreferredSize(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetPreferredSize(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFlexibleSize(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetFlexibleSize(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMinWidth(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetMinWidth(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPreferredWidth(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetPreferredWidth(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFlexibleWidth(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetFlexibleWidth(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMinHeight(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetMinHeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPreferredHeight(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetPreferredHeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFlexibleHeight(IntPtr l) {
		try{
			UnityEngine.RectTransform a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.UI.LayoutUtility.GetFlexibleHeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLayoutProperty(IntPtr l) {
		try{
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutUtility");
		addMember(l,GetMinSize, "GetMinSize");
		addMember(l,GetPreferredSize, "GetPreferredSize");
		addMember(l,GetFlexibleSize, "GetFlexibleSize");
		addMember(l,GetMinWidth, "GetMinWidth");
		addMember(l,GetPreferredWidth, "GetPreferredWidth");
		addMember(l,GetFlexibleWidth, "GetFlexibleWidth");
		addMember(l,GetMinHeight, "GetMinHeight");
		addMember(l,GetPreferredHeight, "GetPreferredHeight");
		addMember(l,GetFlexibleHeight, "GetFlexibleHeight");
		addMember(l,GetLayoutProperty, "GetLayoutProperty");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.LayoutUtility));
		LuaDLL.lua_pop(l, 1);
	}
}
