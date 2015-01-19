using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Toggle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try{
			UnityEngine.UI.Toggle self=checkSelf<UnityEngine.UI.Toggle>(l);
			UnityEngine.UI.CanvasUpdate a1;
			checkEnum(l,2,out a1);
			self.Rebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerClick(IntPtr l) {
		try{
			UnityEngine.UI.Toggle self=checkSelf<UnityEngine.UI.Toggle>(l);
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
			UnityEngine.UI.Toggle self=checkSelf<UnityEngine.UI.Toggle>(l);
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
	static public int get_toggleTransition(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		pushValue(l,o.toggleTransition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_toggleTransition(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		UnityEngine.UI.Toggle.ToggleTransition v;
		checkEnum(l,2,out v);
		o.toggleTransition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_graphic(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		pushValue(l,o.graphic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_graphic(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		UnityEngine.UI.Graphic v;
		checkType(l,2,out v);
		o.graphic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChanged(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		pushValue(l,o.onValueChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChanged(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		UnityEngine.UI.Toggle.ToggleEvent v;
		checkType(l,2,out v);
		o.onValueChanged=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_group(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		pushValue(l,o.group);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_group(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		UnityEngine.UI.ToggleGroup v;
		checkType(l,2,out v);
		o.group=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOn(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		pushValue(l,o.isOn);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isOn(IntPtr l) {
		UnityEngine.UI.Toggle o = checkSelf<UnityEngine.UI.Toggle>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isOn=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Toggle");
		addMember(l,Rebuild, "Rebuild");
		addMember(l,OnPointerClick, "OnPointerClick");
		addMember(l,OnSubmit, "OnSubmit");
		addMember(l,get_toggleTransition, "get_toggleTransition");
		addMember(l,set_toggleTransition, "set_toggleTransition");
		addMember(l,get_graphic, "get_graphic");
		addMember(l,set_graphic, "set_graphic");
		addMember(l,get_onValueChanged, "get_onValueChanged");
		addMember(l,set_onValueChanged, "set_onValueChanged");
		addMember(l,get_group, "get_group");
		addMember(l,set_group, "set_group");
		addMember(l,get_isOn, "get_isOn");
		addMember(l,set_isOn, "set_isOn");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Toggle),typeof(UnityEngine.UI.Selectable));
		LuaDLL.lua_pop(l, 1);
	}
}
