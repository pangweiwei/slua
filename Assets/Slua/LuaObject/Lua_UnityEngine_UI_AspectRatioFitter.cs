using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_AspectRatioFitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.AspectRatioFitter self=checkSelf<UnityEngine.UI.AspectRatioFitter>(l);
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
			UnityEngine.UI.AspectRatioFitter self=checkSelf<UnityEngine.UI.AspectRatioFitter>(l);
			self.SetLayoutVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectMode(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter o = checkSelf<UnityEngine.UI.AspectRatioFitter>(l);
		pushValue(l,o.aspectMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectMode(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter o = checkSelf<UnityEngine.UI.AspectRatioFitter>(l);
		UnityEngine.UI.AspectRatioFitter.AspectMode v;
		checkEnum(l,2,out v);
		o.aspectMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectRatio(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter o = checkSelf<UnityEngine.UI.AspectRatioFitter>(l);
		pushValue(l,o.aspectRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectRatio(IntPtr l) {
		UnityEngine.UI.AspectRatioFitter o = checkSelf<UnityEngine.UI.AspectRatioFitter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.aspectRatio=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.AspectRatioFitter");
		addMember(l,SetLayoutHorizontal, "SetLayoutHorizontal");
		addMember(l,SetLayoutVertical, "SetLayoutVertical");
		addMember(l,get_aspectMode, "get_aspectMode");
		addMember(l,set_aspectMode, "set_aspectMode");
		addMember(l,get_aspectRatio, "get_aspectRatio");
		addMember(l,set_aspectRatio, "set_aspectRatio");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.AspectRatioFitter),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
