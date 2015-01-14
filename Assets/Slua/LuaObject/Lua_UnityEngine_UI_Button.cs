using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Button : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerClick(IntPtr l) {
		try{
			UnityEngine.UI.Button self=checkSelf<UnityEngine.UI.Button>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerClick(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSubmit(IntPtr l) {
		try{
			UnityEngine.UI.Button self=checkSelf<UnityEngine.UI.Button>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSubmit(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onClick(IntPtr l) {
		UnityEngine.UI.Button o = checkSelf<UnityEngine.UI.Button>(l);
		pushValue(l,o.onClick);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onClick(IntPtr l) {
		UnityEngine.UI.Button o = checkSelf<UnityEngine.UI.Button>(l);
		UnityEngine.UI.Button.ButtonClickedEvent v;
		checkType(l,2,out v);
		o.onClick=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Button");
		addMember(l,OnPointerClick, "OnPointerClick");
		addMember(l,OnSubmit, "OnSubmit");
		addMember(l,get_onClick, "get_onClick");
		addMember(l,set_onClick, "set_onClick");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Button),typeof(UnityEngine.UI.Selectable));
		LuaDLL.lua_pop(l, 1);
	}
}
