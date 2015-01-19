using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ScrollRect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try{
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
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
	static public int IsActive(IntPtr l) {
		try{
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
			System.Boolean ret=self.IsActive();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopMovement(IntPtr l) {
		try{
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
			self.StopMovement();
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
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
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
	static public int OnInitializePotentialDrag(IntPtr l) {
		try{
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
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
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
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
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
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
	static public int OnDrag(IntPtr l) {
		try{
			UnityEngine.UI.ScrollRect self=checkSelf<UnityEngine.UI.ScrollRect>(l);
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
	static public int get_content(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.content);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_content(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		UnityEngine.RectTransform v;
		checkType(l,2,out v);
		o.content=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontal(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.horizontal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontal(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.horizontal=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertical(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.vertical);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vertical(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.vertical=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_movementType(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.movementType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_movementType(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		UnityEngine.UI.ScrollRect.MovementType v;
		checkEnum(l,2,out v);
		o.movementType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_elasticity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.elasticity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_elasticity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.elasticity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertia(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.inertia);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertia(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.inertia=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decelerationRate(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.decelerationRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decelerationRate(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.decelerationRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollSensitivity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.scrollSensitivity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollSensitivity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.scrollSensitivity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.horizontalScrollbar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		UnityEngine.UI.Scrollbar v;
		checkType(l,2,out v);
		o.horizontalScrollbar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.verticalScrollbar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		UnityEngine.UI.Scrollbar v;
		checkType(l,2,out v);
		o.verticalScrollbar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChanged(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.onValueChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChanged(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		UnityEngine.UI.ScrollRect.ScrollRectEvent v;
		checkType(l,2,out v);
		o.onValueChanged=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.normalizedPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.normalizedPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.horizontalNormalizedPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.horizontalNormalizedPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		pushValue(l,o.verticalNormalizedPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = checkSelf<UnityEngine.UI.ScrollRect>(l);
		System.Single v;
		checkType(l,2,out v);
		o.verticalNormalizedPosition=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ScrollRect");
		addMember(l,Rebuild, "Rebuild");
		addMember(l,IsActive, "IsActive");
		addMember(l,StopMovement, "StopMovement");
		addMember(l,OnScroll, "OnScroll");
		addMember(l,OnInitializePotentialDrag, "OnInitializePotentialDrag");
		addMember(l,OnBeginDrag, "OnBeginDrag");
		addMember(l,OnEndDrag, "OnEndDrag");
		addMember(l,OnDrag, "OnDrag");
		addMember(l,get_content, "get_content");
		addMember(l,set_content, "set_content");
		addMember(l,get_horizontal, "get_horizontal");
		addMember(l,set_horizontal, "set_horizontal");
		addMember(l,get_vertical, "get_vertical");
		addMember(l,set_vertical, "set_vertical");
		addMember(l,get_movementType, "get_movementType");
		addMember(l,set_movementType, "set_movementType");
		addMember(l,get_elasticity, "get_elasticity");
		addMember(l,set_elasticity, "set_elasticity");
		addMember(l,get_inertia, "get_inertia");
		addMember(l,set_inertia, "set_inertia");
		addMember(l,get_decelerationRate, "get_decelerationRate");
		addMember(l,set_decelerationRate, "set_decelerationRate");
		addMember(l,get_scrollSensitivity, "get_scrollSensitivity");
		addMember(l,set_scrollSensitivity, "set_scrollSensitivity");
		addMember(l,get_horizontalScrollbar, "get_horizontalScrollbar");
		addMember(l,set_horizontalScrollbar, "set_horizontalScrollbar");
		addMember(l,get_verticalScrollbar, "get_verticalScrollbar");
		addMember(l,set_verticalScrollbar, "set_verticalScrollbar");
		addMember(l,get_onValueChanged, "get_onValueChanged");
		addMember(l,set_onValueChanged, "set_onValueChanged");
		addMember(l,get_velocity, "get_velocity");
		addMember(l,set_velocity, "set_velocity");
		addMember(l,get_normalizedPosition, "get_normalizedPosition");
		addMember(l,set_normalizedPosition, "set_normalizedPosition");
		addMember(l,get_horizontalNormalizedPosition, "get_horizontalNormalizedPosition");
		addMember(l,set_horizontalNormalizedPosition, "set_horizontalNormalizedPosition");
		addMember(l,get_verticalNormalizedPosition, "get_verticalNormalizedPosition");
		addMember(l,set_verticalNormalizedPosition, "set_verticalNormalizedPosition");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.ScrollRect),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
