using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Mask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MaskEnabled(IntPtr l) {
		try{
			UnityEngine.UI.Mask self=checkSelf<UnityEngine.UI.Mask>(l);
			System.Boolean ret=self.MaskEnabled();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSiblingGraphicEnabledDisabled(IntPtr l) {
		try{
			UnityEngine.UI.Mask self=checkSelf<UnityEngine.UI.Mask>(l);
			self.OnSiblingGraphicEnabledDisabled();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsRaycastLocationValid(IntPtr l) {
		try{
			UnityEngine.UI.Mask self=checkSelf<UnityEngine.UI.Mask>(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.IsRaycastLocationValid(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetModifiedMaterial(IntPtr l) {
		try{
			UnityEngine.UI.Mask self=checkSelf<UnityEngine.UI.Mask>(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Material ret=self.GetModifiedMaterial(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showMaskGraphic(IntPtr l) {
		UnityEngine.UI.Mask o = checkSelf<UnityEngine.UI.Mask>(l);
		pushValue(l,o.showMaskGraphic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showMaskGraphic(IntPtr l) {
		UnityEngine.UI.Mask o = checkSelf<UnityEngine.UI.Mask>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.showMaskGraphic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rectTransform(IntPtr l) {
		UnityEngine.UI.Mask o = checkSelf<UnityEngine.UI.Mask>(l);
		pushValue(l,o.rectTransform);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Mask");
		addMember(l,MaskEnabled, "MaskEnabled");
		addMember(l,OnSiblingGraphicEnabledDisabled, "OnSiblingGraphicEnabledDisabled");
		addMember(l,IsRaycastLocationValid, "IsRaycastLocationValid");
		addMember(l,GetModifiedMaterial, "GetModifiedMaterial");
		addMember(l,get_showMaskGraphic, "get_showMaskGraphic");
		addMember(l,set_showMaskGraphic, "set_showMaskGraphic");
		addMember(l,get_rectTransform, "get_rectTransform");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Mask),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
