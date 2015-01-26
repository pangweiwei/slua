using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacing(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
		pushValue(l,o.spacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacing(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.spacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childForceExpandWidth(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
		pushValue(l,o.childForceExpandWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childForceExpandWidth(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.childForceExpandWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childForceExpandHeight(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
		pushValue(l,o.childForceExpandHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childForceExpandHeight(IntPtr l) {
		UnityEngine.UI.HorizontalOrVerticalLayoutGroup o = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.childForceExpandHeight=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.HorizontalOrVerticalLayoutGroup");
		addMember(l,"spacing",get_spacing,set_spacing);
		addMember(l,"childForceExpandWidth",get_childForceExpandWidth,set_childForceExpandWidth);
		addMember(l,"childForceExpandHeight",get_childForceExpandHeight,set_childForceExpandHeight);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup),typeof(UnityEngine.UI.LayoutGroup));
	}
}
