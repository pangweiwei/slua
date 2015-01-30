using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Slider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try{
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
			UnityEngine.UI.Slider self=(UnityEngine.UI.Slider)checkSelf(l);
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
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.fillRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillRect(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		UnityEngine.RectTransform v;
		checkType(l,2,out v);
		o.fillRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_handleRect(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.handleRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_handleRect(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		UnityEngine.RectTransform v;
		checkType(l,2,out v);
		o.handleRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.direction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		UnityEngine.UI.Slider.Direction v;
		checkEnum(l,2,out v);
		o.direction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minValue(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.minValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minValue(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minValue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxValue(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.maxValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxValue(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.maxValue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wholeNumbers(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.wholeNumbers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wholeNumbers(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.wholeNumbers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedValue(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.normalizedValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedValue(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.normalizedValue=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChanged(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		pushValue(l,o.onValueChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChanged(IntPtr l) {
		UnityEngine.UI.Slider o = (UnityEngine.UI.Slider)checkSelf(l);
		UnityEngine.UI.Slider.SliderEvent v;
		checkType(l,2,out v);
		o.onValueChanged=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Slider");
		addMember(l,Rebuild);
		addMember(l,OnPointerDown);
		addMember(l,OnDrag);
		addMember(l,OnMove);
		addMember(l,FindSelectableOnLeft);
		addMember(l,FindSelectableOnRight);
		addMember(l,FindSelectableOnUp);
		addMember(l,FindSelectableOnDown);
		addMember(l,OnInitializePotentialDrag);
		addMember(l,SetDirection);
		addMember(l,"fillRect",get_fillRect,set_fillRect,true);
		addMember(l,"handleRect",get_handleRect,set_handleRect,true);
		addMember(l,"direction",get_direction,set_direction,true);
		addMember(l,"minValue",get_minValue,set_minValue,true);
		addMember(l,"maxValue",get_maxValue,set_maxValue,true);
		addMember(l,"wholeNumbers",get_wholeNumbers,set_wholeNumbers,true);
		addMember(l,"value",get_value,set_value,true);
		addMember(l,"normalizedValue",get_normalizedValue,set_normalizedValue,true);
		addMember(l,"onValueChanged",get_onValueChanged,set_onValueChanged,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Slider),typeof(UnityEngine.UI.Selectable));
	}
}
