using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Canvas : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Canvas o;
		if(matchType(l,1)){
			o=new UnityEngine.Canvas();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDefaultCanvasMaterial(IntPtr l) {
		try{
			UnityEngine.Material ret=UnityEngine.Canvas.GetDefaultCanvasMaterial();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDefaultCanvasTextMaterial(IntPtr l) {
		try{
			UnityEngine.Material ret=UnityEngine.Canvas.GetDefaultCanvasTextMaterial();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ForceUpdateCanvases(IntPtr l) {
		try{
			UnityEngine.Canvas.ForceUpdateCanvases();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderMode(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.renderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		UnityEngine.RenderMode v;
		checkEnum(l,2,out v);
		o.renderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isRootCanvas(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.isRootCanvas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCamera(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.worldCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldCamera(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.worldCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelRect(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.pixelRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleFactor(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.scaleFactor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleFactor(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Single v;
		checkType(l,2,out v);
		o.scaleFactor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referencePixelsPerUnit(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.referencePixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_referencePixelsPerUnit(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Single v;
		checkType(l,2,out v);
		o.referencePixelsPerUnit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overridePixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.overridePixelPerfect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overridePixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.overridePixelPerfect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.pixelPerfect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.pixelPerfect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_planeDistance(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.planeDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_planeDistance(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Single v;
		checkType(l,2,out v);
		o.planeDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderOrder(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.renderOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overrideSorting(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.overrideSorting);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overrideSorting(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.overrideSorting=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.sortingOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.sortingOrder=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerID(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.sortingLayerID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerID(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.sortingLayerID=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerName(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		pushValue(l,o.sortingLayerName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerName(IntPtr l) {
		UnityEngine.Canvas o = checkSelf<UnityEngine.Canvas>(l);
		System.String v;
		checkType(l,2,out v);
		o.sortingLayerName=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Canvas");
		addMember(l,GetDefaultCanvasMaterial, "GetDefaultCanvasMaterial");
		addMember(l,GetDefaultCanvasTextMaterial, "GetDefaultCanvasTextMaterial");
		addMember(l,ForceUpdateCanvases, "ForceUpdateCanvases");
		addMember(l,get_renderMode, "get_renderMode");
		addMember(l,set_renderMode, "set_renderMode");
		addMember(l,get_isRootCanvas, "get_isRootCanvas");
		addMember(l,get_worldCamera, "get_worldCamera");
		addMember(l,set_worldCamera, "set_worldCamera");
		addMember(l,get_pixelRect, "get_pixelRect");
		addMember(l,get_scaleFactor, "get_scaleFactor");
		addMember(l,set_scaleFactor, "set_scaleFactor");
		addMember(l,get_referencePixelsPerUnit, "get_referencePixelsPerUnit");
		addMember(l,set_referencePixelsPerUnit, "set_referencePixelsPerUnit");
		addMember(l,get_overridePixelPerfect, "get_overridePixelPerfect");
		addMember(l,set_overridePixelPerfect, "set_overridePixelPerfect");
		addMember(l,get_pixelPerfect, "get_pixelPerfect");
		addMember(l,set_pixelPerfect, "set_pixelPerfect");
		addMember(l,get_planeDistance, "get_planeDistance");
		addMember(l,set_planeDistance, "set_planeDistance");
		addMember(l,get_renderOrder, "get_renderOrder");
		addMember(l,get_overrideSorting, "get_overrideSorting");
		addMember(l,set_overrideSorting, "set_overrideSorting");
		addMember(l,get_sortingOrder, "get_sortingOrder");
		addMember(l,set_sortingOrder, "set_sortingOrder");
		addMember(l,get_sortingLayerID, "get_sortingLayerID");
		addMember(l,set_sortingLayerID, "set_sortingLayerID");
		addMember(l,get_sortingLayerName, "get_sortingLayerName");
		addMember(l,set_sortingLayerName, "set_sortingLayerName");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Canvas),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
