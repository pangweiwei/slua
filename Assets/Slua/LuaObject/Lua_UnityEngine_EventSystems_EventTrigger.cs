using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_EventTrigger : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerEnter(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerEnter(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerExit(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerExit(a1);
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
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
	static public int OnDrop(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnDrop(a1);
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
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
	static public int OnPointerClick(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
	static public int OnSelect(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSelect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDeselect(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnDeselect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnScroll(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnScroll(a1);
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
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
	static public int OnUpdateSelected(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnUpdateSelected(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnInitializePotentialDrag(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
	static public int OnBeginDrag(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
	static public int OnEndDrag(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnEndDrag(a1);
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
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
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
	static public int OnCancel(IntPtr l) {
		try{
			UnityEngine.EventSystems.EventTrigger self=checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnCancel(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delegates(IntPtr l) {
		UnityEngine.EventSystems.EventTrigger o = checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
		pushValue(l,o.delegates);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delegates(IntPtr l) {
		UnityEngine.EventSystems.EventTrigger o = checkSelf<UnityEngine.EventSystems.EventTrigger>(l);
		List<UnityEngine.EventSystems.EventTrigger.Entry> v;
		checkType(l,2,out v);
		o.delegates=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.EventTrigger");
		addMember(l,OnPointerEnter, "OnPointerEnter");
		addMember(l,OnPointerExit, "OnPointerExit");
		addMember(l,OnDrag, "OnDrag");
		addMember(l,OnDrop, "OnDrop");
		addMember(l,OnPointerDown, "OnPointerDown");
		addMember(l,OnPointerUp, "OnPointerUp");
		addMember(l,OnPointerClick, "OnPointerClick");
		addMember(l,OnSelect, "OnSelect");
		addMember(l,OnDeselect, "OnDeselect");
		addMember(l,OnScroll, "OnScroll");
		addMember(l,OnMove, "OnMove");
		addMember(l,OnUpdateSelected, "OnUpdateSelected");
		addMember(l,OnInitializePotentialDrag, "OnInitializePotentialDrag");
		addMember(l,OnBeginDrag, "OnBeginDrag");
		addMember(l,OnEndDrag, "OnEndDrag");
		addMember(l,OnSubmit, "OnSubmit");
		addMember(l,OnCancel, "OnCancel");
		addMember(l,get_delegates, "get_delegates");
		addMember(l,set_delegates, "set_delegates");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.EventTrigger),typeof(UnityEngine.MonoBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
