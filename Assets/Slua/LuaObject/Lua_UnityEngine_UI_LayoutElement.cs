using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_LayoutElement : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.LayoutElement self=checkSelf<UnityEngine.UI.LayoutElement>(l);
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
			UnityEngine.UI.LayoutElement self=checkSelf<UnityEngine.UI.LayoutElement>(l);
			self.CalculateLayoutInputVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreLayout(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.ignoreLayout);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreLayout(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreLayout=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		System.Single v;
		checkType(l,2,out v);
		o.preferredWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		System.Single v;
		checkType(l,2,out v);
		o.preferredHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		System.Single v;
		checkType(l,2,out v);
		o.flexibleWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		System.Single v;
		checkType(l,2,out v);
		o.flexibleHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.LayoutElement o = checkSelf<UnityEngine.UI.LayoutElement>(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutElement");
		addMember(l,CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal");
		addMember(l,CalculateLayoutInputVertical, "CalculateLayoutInputVertical");
		addMember(l,get_ignoreLayout, "get_ignoreLayout");
		addMember(l,set_ignoreLayout, "set_ignoreLayout");
		addMember(l,get_minWidth, "get_minWidth");
		addMember(l,set_minWidth, "set_minWidth");
		addMember(l,get_minHeight, "get_minHeight");
		addMember(l,set_minHeight, "set_minHeight");
		addMember(l,get_preferredWidth, "get_preferredWidth");
		addMember(l,set_preferredWidth, "set_preferredWidth");
		addMember(l,get_preferredHeight, "get_preferredHeight");
		addMember(l,set_preferredHeight, "set_preferredHeight");
		addMember(l,get_flexibleWidth, "get_flexibleWidth");
		addMember(l,set_flexibleWidth, "set_flexibleWidth");
		addMember(l,get_flexibleHeight, "get_flexibleHeight");
		addMember(l,set_flexibleHeight, "set_flexibleHeight");
		addMember(l,get_layoutPriority, "get_layoutPriority");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.LayoutElement),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
