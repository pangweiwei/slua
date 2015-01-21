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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
			UnityEngine.UI.ScrollRect self=(UnityEngine.UI.ScrollRect)checkSelf(l);
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
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.content);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_content(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		UnityEngine.RectTransform v;
		checkType(l,2,out v);
		o.content=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontal(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.horizontal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontal(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.horizontal=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertical(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.vertical);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vertical(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.vertical=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_movementType(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.movementType);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_movementType(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		UnityEngine.UI.ScrollRect.MovementType v;
		checkEnum(l,2,out v);
		o.movementType=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_elasticity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.elasticity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_elasticity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.elasticity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertia(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.inertia);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertia(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.inertia=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decelerationRate(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.decelerationRate);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decelerationRate(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.decelerationRate=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollSensitivity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.scrollSensitivity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollSensitivity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.scrollSensitivity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.horizontalScrollbar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		UnityEngine.UI.Scrollbar v;
		checkType(l,2,out v);
		o.horizontalScrollbar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.verticalScrollbar);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalScrollbar(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		UnityEngine.UI.Scrollbar v;
		checkType(l,2,out v);
		o.verticalScrollbar=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChanged(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.onValueChanged);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChanged(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		UnityEngine.UI.ScrollRect.ScrollRectEvent v;
		checkType(l,2,out v);
		o.onValueChanged=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.velocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.velocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.normalizedPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.normalizedPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.horizontalNormalizedPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.horizontalNormalizedPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		pushValue(l,o.verticalNormalizedPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalNormalizedPosition(IntPtr l) {
		UnityEngine.UI.ScrollRect o = (UnityEngine.UI.ScrollRect)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.verticalNormalizedPosition=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ScrollRect");
		addMember(l,Rebuild);
		addMember(l,IsActive);
		addMember(l,StopMovement);
		addMember(l,OnScroll);
		addMember(l,OnInitializePotentialDrag);
		addMember(l,OnBeginDrag);
		addMember(l,OnEndDrag);
		addMember(l,OnDrag);
		addMember(l,"content",get_content,set_content);
		addMember(l,"horizontal",get_horizontal,set_horizontal);
		addMember(l,"vertical",get_vertical,set_vertical);
		addMember(l,"movementType",get_movementType,set_movementType);
		addMember(l,"elasticity",get_elasticity,set_elasticity);
		addMember(l,"inertia",get_inertia,set_inertia);
		addMember(l,"decelerationRate",get_decelerationRate,set_decelerationRate);
		addMember(l,"scrollSensitivity",get_scrollSensitivity,set_scrollSensitivity);
		addMember(l,"horizontalScrollbar",get_horizontalScrollbar,set_horizontalScrollbar);
		addMember(l,"verticalScrollbar",get_verticalScrollbar,set_verticalScrollbar);
		addMember(l,"onValueChanged",get_onValueChanged,set_onValueChanged);
		addMember(l,"velocity",get_velocity,set_velocity);
		addMember(l,"normalizedPosition",get_normalizedPosition,set_normalizedPosition);
		addMember(l,"horizontalNormalizedPosition",get_horizontalNormalizedPosition,set_horizontalNormalizedPosition);
		addMember(l,"verticalNormalizedPosition",get_verticalNormalizedPosition,set_verticalNormalizedPosition);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.ScrollRect),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
