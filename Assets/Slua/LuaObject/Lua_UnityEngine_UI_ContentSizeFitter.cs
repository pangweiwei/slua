using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ContentSizeFitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.ContentSizeFitter self=checkSelf<UnityEngine.UI.ContentSizeFitter>(l);
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
			UnityEngine.UI.ContentSizeFitter self=checkSelf<UnityEngine.UI.ContentSizeFitter>(l);
			self.SetLayoutVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = checkSelf<UnityEngine.UI.ContentSizeFitter>(l);
		pushValue(l,o.horizontalFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = checkSelf<UnityEngine.UI.ContentSizeFitter>(l);
		UnityEngine.UI.ContentSizeFitter.FitMode v;
		checkEnum(l,2,out v);
		o.horizontalFit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = checkSelf<UnityEngine.UI.ContentSizeFitter>(l);
		pushValue(l,o.verticalFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = checkSelf<UnityEngine.UI.ContentSizeFitter>(l);
		UnityEngine.UI.ContentSizeFitter.FitMode v;
		checkEnum(l,2,out v);
		o.verticalFit=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ContentSizeFitter");
		addMember(l,SetLayoutHorizontal, "SetLayoutHorizontal");
		addMember(l,SetLayoutVertical, "SetLayoutVertical");
		addMember(l,get_horizontalFit, "get_horizontalFit");
		addMember(l,set_horizontalFit, "set_horizontalFit");
		addMember(l,get_verticalFit, "get_verticalFit");
		addMember(l,set_verticalFit, "set_verticalFit");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.ContentSizeFitter),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
