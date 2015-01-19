using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_LayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.LayoutGroup self=checkSelf<UnityEngine.UI.LayoutGroup>(l);
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
			UnityEngine.UI.LayoutGroup self=checkSelf<UnityEngine.UI.LayoutGroup>(l);
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
			UnityEngine.UI.LayoutGroup self=checkSelf<UnityEngine.UI.LayoutGroup>(l);
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
			UnityEngine.UI.LayoutGroup self=checkSelf<UnityEngine.UI.LayoutGroup>(l);
			self.SetLayoutVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padding(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.padding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padding(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		UnityEngine.RectOffset v;
		checkType(l,2,out v);
		o.padding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childAlignment(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.childAlignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childAlignment(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.childAlignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = checkSelf<UnityEngine.UI.LayoutGroup>(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutGroup");
		addMember(l,CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal");
		addMember(l,CalculateLayoutInputVertical, "CalculateLayoutInputVertical");
		addMember(l,SetLayoutHorizontal, "SetLayoutHorizontal");
		addMember(l,SetLayoutVertical, "SetLayoutVertical");
		addMember(l,get_padding, "get_padding");
		addMember(l,set_padding, "set_padding");
		addMember(l,get_childAlignment, "get_childAlignment");
		addMember(l,set_childAlignment, "set_childAlignment");
		addMember(l,get_minWidth, "get_minWidth");
		addMember(l,get_preferredWidth, "get_preferredWidth");
		addMember(l,get_flexibleWidth, "get_flexibleWidth");
		addMember(l,get_minHeight, "get_minHeight");
		addMember(l,get_preferredHeight, "get_preferredHeight");
		addMember(l,get_flexibleHeight, "get_flexibleHeight");
		addMember(l,get_layoutPriority, "get_layoutPriority");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.LayoutGroup),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
