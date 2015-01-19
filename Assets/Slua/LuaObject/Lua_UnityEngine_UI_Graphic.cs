using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Graphic : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAllDirty(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			self.SetAllDirty();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutDirty(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			self.SetLayoutDirty();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVerticesDirty(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			self.SetVerticesDirty();
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
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			self.SetMaterialDirty();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.UI.CanvasUpdate a1;
			checkEnum(l,2,out a1);
			self.Rebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnRebuildRequested(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			self.OnRebuildRequested();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetNativeSize(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			self.SetNativeSize();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Camera a2;
			checkType(l,3,out a2);
			System.Boolean ret=self.Raycast(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PixelAdjustPoint(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 ret=self.PixelAdjustPoint(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPixelAdjustedRect(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Rect ret=self.GetPixelAdjustedRect();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CrossFadeColor(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			self.CrossFadeColor(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CrossFadeAlpha(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.CrossFadeAlpha(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterDirtyLayoutCallback(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.RegisterDirtyLayoutCallback(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnregisterDirtyLayoutCallback(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.UnregisterDirtyLayoutCallback(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterDirtyVerticesCallback(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.RegisterDirtyVerticesCallback(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnregisterDirtyVerticesCallback(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.UnregisterDirtyVerticesCallback(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterDirtyMaterialCallback(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.RegisterDirtyMaterialCallback(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnregisterDirtyMaterialCallback(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=checkSelf<UnityEngine.UI.Graphic>(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.UnregisterDirtyMaterialCallback(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultGraphicMaterial(IntPtr l) {
		pushValue(l,UnityEngine.UI.Graphic.defaultGraphicMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rectTransform(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.rectTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canvas(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.canvas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canvasRenderer(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.canvasRenderer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultMaterial(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.defaultMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_materialForRendering(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.materialForRendering);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.Graphic o = checkSelf<UnityEngine.UI.Graphic>(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Graphic");
		addMember(l,SetAllDirty, "SetAllDirty");
		addMember(l,SetLayoutDirty, "SetLayoutDirty");
		addMember(l,SetVerticesDirty, "SetVerticesDirty");
		addMember(l,SetMaterialDirty, "SetMaterialDirty");
		addMember(l,Rebuild, "Rebuild");
		addMember(l,OnRebuildRequested, "OnRebuildRequested");
		addMember(l,SetNativeSize, "SetNativeSize");
		addMember(l,Raycast, "Raycast");
		addMember(l,PixelAdjustPoint, "PixelAdjustPoint");
		addMember(l,GetPixelAdjustedRect, "GetPixelAdjustedRect");
		addMember(l,CrossFadeColor, "CrossFadeColor");
		addMember(l,CrossFadeAlpha, "CrossFadeAlpha");
		addMember(l,RegisterDirtyLayoutCallback, "RegisterDirtyLayoutCallback");
		addMember(l,UnregisterDirtyLayoutCallback, "UnregisterDirtyLayoutCallback");
		addMember(l,RegisterDirtyVerticesCallback, "RegisterDirtyVerticesCallback");
		addMember(l,UnregisterDirtyVerticesCallback, "UnregisterDirtyVerticesCallback");
		addMember(l,RegisterDirtyMaterialCallback, "RegisterDirtyMaterialCallback");
		addMember(l,UnregisterDirtyMaterialCallback, "UnregisterDirtyMaterialCallback");
		addMember(l,get_defaultGraphicMaterial, "get_defaultGraphicMaterial");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_depth, "get_depth");
		addMember(l,get_rectTransform, "get_rectTransform");
		addMember(l,get_canvas, "get_canvas");
		addMember(l,get_canvasRenderer, "get_canvasRenderer");
		addMember(l,get_defaultMaterial, "get_defaultMaterial");
		addMember(l,get_material, "get_material");
		addMember(l,set_material, "set_material");
		addMember(l,get_materialForRendering, "get_materialForRendering");
		addMember(l,get_mainTexture, "get_mainTexture");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Graphic),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
