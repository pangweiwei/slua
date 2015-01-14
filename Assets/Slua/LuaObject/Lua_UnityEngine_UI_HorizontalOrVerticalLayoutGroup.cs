using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacing(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = checkSelf<UnityEngine.UI.HorizontalOrVerticalLayoutGroup>(l);
		pushValue(l,o.spacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacing(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = checkSelf<UnityEngine.UI.HorizontalOrVerticalLayoutGroup>(l);
		System.Single v;
		checkType(l,2,out v);
		o.spacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childForceExpandWidth(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = checkSelf<UnityEngine.UI.HorizontalOrVerticalLayoutGroup>(l);
		pushValue(l,o.childForceExpandWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childForceExpandWidth(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = checkSelf<UnityEngine.UI.HorizontalOrVerticalLayoutGroup>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.childForceExpandWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childForceExpandHeight(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = checkSelf<UnityEngine.UI.HorizontalOrVerticalLayoutGroup>(l);
		pushValue(l,o.childForceExpandHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childForceExpandHeight(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = checkSelf<UnityEngine.UI.HorizontalOrVerticalLayoutGroup>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.childForceExpandHeight=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.HorizontalOrVerticalLayoutGroup");
		addMember(l,get_spacing, "get_spacing");
		addMember(l,set_spacing, "set_spacing");
		addMember(l,get_childForceExpandWidth, "get_childForceExpandWidth");
		addMember(l,set_childForceExpandWidth, "set_childForceExpandWidth");
		addMember(l,get_childForceExpandHeight, "get_childForceExpandHeight");
		addMember(l,set_childForceExpandHeight, "set_childForceExpandHeight");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup),typeof(UnityEngine.UI.LayoutGroup));
		LuaDLL.lua_pop(l, 1);
	}
}
