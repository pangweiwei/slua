using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_CanvasScaler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiScaleMode(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.uiScaleMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiScaleMode(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		UnityEngine.UI.CanvasScaler.ScaleMode v;
		checkEnum(l,2,out v);
		o.uiScaleMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referencePixelsPerUnit(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.referencePixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_referencePixelsPerUnit(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		System.Single v;
		checkType(l,2,out v);
		o.referencePixelsPerUnit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleFactor(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.scaleFactor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleFactor(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		System.Single v;
		checkType(l,2,out v);
		o.scaleFactor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referenceResolution(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.referenceResolution);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_referenceResolution(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.referenceResolution=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenMatchMode(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.screenMatchMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_screenMatchMode(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		UnityEngine.UI.CanvasScaler.ScreenMatchMode v;
		checkEnum(l,2,out v);
		o.screenMatchMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_matchWidthOrHeight(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.matchWidthOrHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_matchWidthOrHeight(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		System.Single v;
		checkType(l,2,out v);
		o.matchWidthOrHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_physicalUnit(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.physicalUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_physicalUnit(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		UnityEngine.UI.CanvasScaler.Unit v;
		checkEnum(l,2,out v);
		o.physicalUnit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fallbackScreenDPI(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.fallbackScreenDPI);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fallbackScreenDPI(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		System.Single v;
		checkType(l,2,out v);
		o.fallbackScreenDPI=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultSpriteDPI(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.defaultSpriteDPI);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultSpriteDPI(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		System.Single v;
		checkType(l,2,out v);
		o.defaultSpriteDPI=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicPixelsPerUnit(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		pushValue(l,o.dynamicPixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicPixelsPerUnit(IntPtr l) {
		UnityEngine.UI.CanvasScaler o = checkSelf<UnityEngine.UI.CanvasScaler>(l);
		System.Single v;
		checkType(l,2,out v);
		o.dynamicPixelsPerUnit=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.CanvasScaler");
		addMember(l,get_uiScaleMode, "get_uiScaleMode");
		addMember(l,set_uiScaleMode, "set_uiScaleMode");
		addMember(l,get_referencePixelsPerUnit, "get_referencePixelsPerUnit");
		addMember(l,set_referencePixelsPerUnit, "set_referencePixelsPerUnit");
		addMember(l,get_scaleFactor, "get_scaleFactor");
		addMember(l,set_scaleFactor, "set_scaleFactor");
		addMember(l,get_referenceResolution, "get_referenceResolution");
		addMember(l,set_referenceResolution, "set_referenceResolution");
		addMember(l,get_screenMatchMode, "get_screenMatchMode");
		addMember(l,set_screenMatchMode, "set_screenMatchMode");
		addMember(l,get_matchWidthOrHeight, "get_matchWidthOrHeight");
		addMember(l,set_matchWidthOrHeight, "set_matchWidthOrHeight");
		addMember(l,get_physicalUnit, "get_physicalUnit");
		addMember(l,set_physicalUnit, "set_physicalUnit");
		addMember(l,get_fallbackScreenDPI, "get_fallbackScreenDPI");
		addMember(l,set_fallbackScreenDPI, "set_fallbackScreenDPI");
		addMember(l,get_defaultSpriteDPI, "get_defaultSpriteDPI");
		addMember(l,set_defaultSpriteDPI, "set_defaultSpriteDPI");
		addMember(l,get_dynamicPixelsPerUnit, "get_dynamicPixelsPerUnit");
		addMember(l,set_dynamicPixelsPerUnit, "set_dynamicPixelsPerUnit");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.CanvasScaler),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
