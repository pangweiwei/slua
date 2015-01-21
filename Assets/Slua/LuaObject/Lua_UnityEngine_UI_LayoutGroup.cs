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
			UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
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
			UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
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
			UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
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
			UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
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
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.padding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padding(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		UnityEngine.RectOffset v;
		checkType(l,2,out v);
		o.padding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childAlignment(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.childAlignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childAlignment(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		o.childAlignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.LayoutGroup o = (UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,o.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutGroup");
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,SetLayoutHorizontal);
		addMember(l,SetLayoutVertical);
		addMember(l,"padding",get_padding,set_padding);
		addMember(l,"childAlignment",get_childAlignment,set_childAlignment);
		addMember(l,"minWidth",get_minWidth,null);
		addMember(l,"preferredWidth",get_preferredWidth,null);
		addMember(l,"flexibleWidth",get_flexibleWidth,null);
		addMember(l,"minHeight",get_minHeight,null);
		addMember(l,"preferredHeight",get_preferredHeight,null);
		addMember(l,"flexibleHeight",get_flexibleHeight,null);
		addMember(l,"layoutPriority",get_layoutPriority,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.LayoutGroup),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
