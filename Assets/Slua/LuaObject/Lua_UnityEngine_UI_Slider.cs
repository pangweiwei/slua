using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Slider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
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
	static public int OnPointerDown(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerDown(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrag(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnMove(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.EventSystems.AxisEventData a1;
			checkType(l,2,out a1);
			self.OnMove(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindSelectableOnLeft(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.UI.Selectable ret=self.FindSelectableOnLeft();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindSelectableOnRight(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.UI.Selectable ret=self.FindSelectableOnRight();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindSelectableOnUp(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.UI.Selectable ret=self.FindSelectableOnUp();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindSelectableOnDown(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.UI.Selectable ret=self.FindSelectableOnDown();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnInitializePotentialDrag(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnInitializePotentialDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDirection(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=checkSelf<UnityEngine.UI.Slider>(l);
			UnityEngine.UI.Slider.Direction a1;
			checkEnum(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetDirection(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillRect(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.fillRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillRect(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		UnityEngine.RectTransform v;
		checkType(l,2,out v);
		o.fillRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_handleRect(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.handleRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_handleRect(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		UnityEngine.RectTransform v;
		checkType(l,2,out v);
		o.handleRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.direction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		UnityEngine.UI.Slider.Direction v;
		checkEnum(l,2,out v);
		o.direction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minValue(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.minValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minValue(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minValue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxValue(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.maxValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxValue(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxValue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wholeNumbers(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.wholeNumbers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wholeNumbers(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.wholeNumbers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		System.Single v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedValue(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.normalizedValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedValue(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		System.Single v;
		checkType(l,2,out v);
		o.normalizedValue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChanged(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		pushValue(l,o.onValueChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChanged(IntPtr l) {
		UnityEngine.UI.Slider o = checkSelf<UnityEngine.UI.Slider>(l);
		UnityEngine.UI.Slider.SliderEvent v;
		checkType(l,2,out v);
		o.onValueChanged=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Slider");
		addMember(l,Rebuild, "Rebuild");
		addMember(l,OnPointerDown, "OnPointerDown");
		addMember(l,OnDrag, "OnDrag");
		addMember(l,OnMove, "OnMove");
		addMember(l,FindSelectableOnLeft, "FindSelectableOnLeft");
		addMember(l,FindSelectableOnRight, "FindSelectableOnRight");
		addMember(l,FindSelectableOnUp, "FindSelectableOnUp");
		addMember(l,FindSelectableOnDown, "FindSelectableOnDown");
		addMember(l,OnInitializePotentialDrag, "OnInitializePotentialDrag");
		addMember(l,SetDirection, "SetDirection");
		addMember(l,get_fillRect, "get_fillRect");
		addMember(l,set_fillRect, "set_fillRect");
		addMember(l,get_handleRect, "get_handleRect");
		addMember(l,set_handleRect, "set_handleRect");
		addMember(l,get_direction, "get_direction");
		addMember(l,set_direction, "set_direction");
		addMember(l,get_minValue, "get_minValue");
		addMember(l,set_minValue, "set_minValue");
		addMember(l,get_maxValue, "get_maxValue");
		addMember(l,set_maxValue, "set_maxValue");
		addMember(l,get_wholeNumbers, "get_wholeNumbers");
		addMember(l,set_wholeNumbers, "set_wholeNumbers");
		addMember(l,get_value, "get_value");
		addMember(l,set_value, "set_value");
		addMember(l,get_normalizedValue, "get_normalizedValue");
		addMember(l,set_normalizedValue, "set_normalizedValue");
		addMember(l,get_onValueChanged, "get_onValueChanged");
		addMember(l,set_onValueChanged, "set_onValueChanged");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Slider),typeof(UnityEngine.UI.Selectable));
		LuaDLL.lua_pop(l, 1);
	}
}
