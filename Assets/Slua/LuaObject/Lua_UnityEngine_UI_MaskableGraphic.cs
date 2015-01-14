using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_MaskableGraphic : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ParentMaskStateChanged(IntPtr l) {
		try{
			UnityEngine.UI.MaskableGraphic self=checkSelf<UnityEngine.UI.MaskableGraphic>(l);
			self.ParentMaskStateChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetMaterialDirty(IntPtr l) {
		try{
			UnityEngine.UI.MaskableGraphic self=checkSelf<UnityEngine.UI.MaskableGraphic>(l);
			self.SetMaterialDirty();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maskable(IntPtr l) {
		UnityEngine.UI.MaskableGraphic o = checkSelf<UnityEngine.UI.MaskableGraphic>(l);
		pushValue(l,o.maskable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maskable(IntPtr l) {
		UnityEngine.UI.MaskableGraphic o = checkSelf<UnityEngine.UI.MaskableGraphic>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.maskable=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.UI.MaskableGraphic o = checkSelf<UnityEngine.UI.MaskableGraphic>(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.UI.MaskableGraphic o = checkSelf<UnityEngine.UI.MaskableGraphic>(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.MaskableGraphic");
		addMember(l,ParentMaskStateChanged, "ParentMaskStateChanged");
		addMember(l,SetMaterialDirty, "SetMaterialDirty");
		addMember(l,get_maskable, "get_maskable");
		addMember(l,set_maskable, "set_maskable");
		addMember(l,get_material, "get_material");
		addMember(l,set_material, "set_material");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.MaskableGraphic),typeof(UnityEngine.UI.Graphic));
		LuaDLL.lua_pop(l, 1);
	}
}
