using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Scrollbar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try{
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
	static public int OnBeginDrag(IntPtr l) {
		try{
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnBeginDrag(a1);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
	static public int OnPointerDown(IntPtr l) {
		try{
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
	static public int OnPointerUp(IntPtr l) {
		try{
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerUp(a1);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
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
			UnityEngine.UI.Scrollbar self=(UnityEngine.UI.Scrollbar)checkSelf(l);
			UnityEngine.UI.Scrollbar.Direction a1;
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
	static public int get_handleRect(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		pushValue(l,o.handleRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_handleRect(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		UnityEngine.RectTransform v;
		checkType(l,2,out v);
		o.handleRect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		pushValue(l,o.direction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		UnityEngine.UI.Scrollbar.Direction v;
		checkEnum(l,2,out v);
		o.direction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_value(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		pushValue(l,o.value);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_value(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.value=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numberOfSteps(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		pushValue(l,o.numberOfSteps);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numberOfSteps(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.numberOfSteps=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChanged(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		pushValue(l,o.onValueChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChanged(IntPtr l) {
		UnityEngine.UI.Scrollbar o = (UnityEngine.UI.Scrollbar)checkSelf(l);
		UnityEngine.UI.Scrollbar.ScrollEvent v;
		checkType(l,2,out v);
		o.onValueChanged=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Scrollbar");
		addMember(l,Rebuild);
		addMember(l,OnBeginDrag);
		addMember(l,OnDrag);
		addMember(l,OnPointerDown);
		addMember(l,OnPointerUp);
		addMember(l,OnMove);
		addMember(l,FindSelectableOnLeft);
		addMember(l,FindSelectableOnRight);
		addMember(l,FindSelectableOnUp);
		addMember(l,FindSelectableOnDown);
		addMember(l,OnInitializePotentialDrag);
		addMember(l,SetDirection);
		addMember(l,"handleRect",get_handleRect,set_handleRect);
		addMember(l,"direction",get_direction,set_direction);
		addMember(l,"value",get_value,set_value);
		addMember(l,"size",get_size,set_size);
		addMember(l,"numberOfSteps",get_numberOfSteps,set_numberOfSteps);
		addMember(l,"onValueChanged",get_onValueChanged,set_onValueChanged);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Scrollbar),typeof(UnityEngine.UI.Selectable));
	}
}
