using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Selectable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsInteractable(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
			System.Boolean ret=self.IsInteractable();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindSelectable(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.UI.Selectable ret=self.FindSelectable(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindSelectableOnLeft(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
	static public int OnMove(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
	static public int OnPointerDown(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
	static public int OnPointerEnter(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
	static public int OnSelect(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
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
	static public int Select(IntPtr l) {
		try{
			UnityEngine.UI.Selectable self=checkSelf<UnityEngine.UI.Selectable>(l);
			self.Select();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allSelectables(IntPtr l) {
		pushValue(l,UnityEngine.UI.Selectable.allSelectables);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_navigation(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.navigation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_navigation(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		UnityEngine.UI.Navigation v;
		checkType(l,2,out v);
		o.navigation=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_transition(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.transition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_transition(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		UnityEngine.UI.Selectable.Transition v;
		checkEnum(l,2,out v);
		o.transition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.colors);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colors(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		UnityEngine.UI.ColorBlock v;
		checkType(l,2,out v);
		o.colors=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteState(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.spriteState);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteState(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		UnityEngine.UI.SpriteState v;
		checkType(l,2,out v);
		o.spriteState=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animationTriggers(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.animationTriggers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animationTriggers(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		UnityEngine.UI.AnimationTriggers v;
		checkType(l,2,out v);
		o.animationTriggers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetGraphic(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.targetGraphic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_targetGraphic(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		UnityEngine.UI.Graphic v;
		checkType(l,2,out v);
		o.targetGraphic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interactable(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.interactable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interactable(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.interactable=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_image(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.image);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_image(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		UnityEngine.UI.Image v;
		checkType(l,2,out v);
		o.image=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animator(IntPtr l) {
		UnityEngine.UI.Selectable o = checkSelf<UnityEngine.UI.Selectable>(l);
		pushValue(l,o.animator);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Selectable");
		addMember(l,IsInteractable, "IsInteractable");
		addMember(l,FindSelectable, "FindSelectable");
		addMember(l,FindSelectableOnLeft, "FindSelectableOnLeft");
		addMember(l,FindSelectableOnRight, "FindSelectableOnRight");
		addMember(l,FindSelectableOnUp, "FindSelectableOnUp");
		addMember(l,FindSelectableOnDown, "FindSelectableOnDown");
		addMember(l,OnMove, "OnMove");
		addMember(l,OnPointerDown, "OnPointerDown");
		addMember(l,OnPointerUp, "OnPointerUp");
		addMember(l,OnPointerEnter, "OnPointerEnter");
		addMember(l,OnPointerExit, "OnPointerExit");
		addMember(l,OnSelect, "OnSelect");
		addMember(l,OnDeselect, "OnDeselect");
		addMember(l,Select, "Select");
		addMember(l,get_allSelectables, "get_allSelectables");
		addMember(l,get_navigation, "get_navigation");
		addMember(l,set_navigation, "set_navigation");
		addMember(l,get_transition, "get_transition");
		addMember(l,set_transition, "set_transition");
		addMember(l,get_colors, "get_colors");
		addMember(l,set_colors, "set_colors");
		addMember(l,get_spriteState, "get_spriteState");
		addMember(l,set_spriteState, "set_spriteState");
		addMember(l,get_animationTriggers, "get_animationTriggers");
		addMember(l,set_animationTriggers, "set_animationTriggers");
		addMember(l,get_targetGraphic, "get_targetGraphic");
		addMember(l,set_targetGraphic, "set_targetGraphic");
		addMember(l,get_interactable, "get_interactable");
		addMember(l,set_interactable, "set_interactable");
		addMember(l,get_image, "get_image");
		addMember(l,set_image, "set_image");
		addMember(l,get_animator, "get_animator");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Selectable),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
