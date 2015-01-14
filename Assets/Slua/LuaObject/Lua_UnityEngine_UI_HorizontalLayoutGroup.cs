using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_HorizontalLayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.HorizontalLayoutGroup self=checkSelf<UnityEngine.UI.HorizontalLayoutGroup>(l);
			self.CalculateLayoutInputHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		try{
			UnityEngine.UI.HorizontalLayoutGroup self=checkSelf<UnityEngine.UI.HorizontalLayoutGroup>(l);
			self.CalculateLayoutInputVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.HorizontalLayoutGroup self=checkSelf<UnityEngine.UI.HorizontalLayoutGroup>(l);
			self.SetLayoutHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutVertical(IntPtr l) {
		try{
			UnityEngine.UI.HorizontalLayoutGroup self=checkSelf<UnityEngine.UI.HorizontalLayoutGroup>(l);
			self.SetLayoutVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.HorizontalLayoutGroup");
		addMember(l,CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal");
		addMember(l,CalculateLayoutInputVertical, "CalculateLayoutInputVertical");
		addMember(l,SetLayoutHorizontal, "SetLayoutHorizontal");
		addMember(l,SetLayoutVertical, "SetLayoutVertical");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.HorizontalLayoutGroup),typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup));
		LuaDLL.lua_pop(l, 1);
	}
}
