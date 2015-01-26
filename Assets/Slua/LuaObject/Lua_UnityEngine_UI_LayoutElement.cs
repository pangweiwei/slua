using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_LayoutElement : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
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
			UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
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
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.ignoreLayout);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreLayout(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.ignoreLayout=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.minHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.preferredWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.preferredHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.flexibleWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.flexibleHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.LayoutElement o = (UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutElement");
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,"ignoreLayout",get_ignoreLayout,set_ignoreLayout);
		addMember(l,"minWidth",get_minWidth,set_minWidth);
		addMember(l,"minHeight",get_minHeight,set_minHeight);
		addMember(l,"preferredWidth",get_preferredWidth,set_preferredWidth);
		addMember(l,"preferredHeight",get_preferredHeight,set_preferredHeight);
		addMember(l,"flexibleWidth",get_flexibleWidth,set_flexibleWidth);
		addMember(l,"flexibleHeight",get_flexibleHeight,set_flexibleHeight);
		addMember(l,"layoutPriority",get_layoutPriority,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.LayoutElement),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
