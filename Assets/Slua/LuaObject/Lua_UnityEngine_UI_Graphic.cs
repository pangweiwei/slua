using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Graphic : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAllDirty(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
	static public int SetNativeSize(IntPtr l) {
		try{
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
			UnityEngine.UI.Graphic self=(UnityEngine.UI.Graphic)checkSelf(l);
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
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rectTransform(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.rectTransform);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canvas(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.canvas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_canvasRenderer(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.canvasRenderer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultMaterial(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.defaultMaterial);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_materialForRendering(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.materialForRendering);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		UnityEngine.UI.Graphic o = (UnityEngine.UI.Graphic)checkSelf(l);
		pushValue(l,o.mainTexture);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Graphic");
		addMember(l,SetAllDirty);
		addMember(l,SetLayoutDirty);
		addMember(l,SetVerticesDirty);
		addMember(l,SetMaterialDirty);
		addMember(l,Rebuild);
		addMember(l,SetNativeSize);
		addMember(l,Raycast);
		addMember(l,PixelAdjustPoint);
		addMember(l,GetPixelAdjustedRect);
		addMember(l,CrossFadeColor);
		addMember(l,CrossFadeAlpha);
		addMember(l,RegisterDirtyLayoutCallback);
		addMember(l,UnregisterDirtyLayoutCallback);
		addMember(l,RegisterDirtyVerticesCallback);
		addMember(l,UnregisterDirtyVerticesCallback);
		addMember(l,RegisterDirtyMaterialCallback);
		addMember(l,UnregisterDirtyMaterialCallback);
		addMember(l,"defaultGraphicMaterial",get_defaultGraphicMaterial,null,false);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"depth",get_depth,null,true);
		addMember(l,"rectTransform",get_rectTransform,null,true);
		addMember(l,"canvas",get_canvas,null,true);
		addMember(l,"canvasRenderer",get_canvasRenderer,null,true);
		addMember(l,"defaultMaterial",get_defaultMaterial,null,true);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"materialForRendering",get_materialForRendering,null,true);
		addMember(l,"mainTexture",get_mainTexture,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Graphic),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
