using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Canvas : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Canvas o;
		o=new UnityEngine.Canvas();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDefaultCanvasMaterial_s(IntPtr l) {
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
	static public int GetDefaultCanvasTextMaterial_s(IntPtr l) {
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
	static public int ForceUpdateCanvases_s(IntPtr l) {
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
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushEnum(l,(int)o.renderMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		UnityEngine.RenderMode v;
		checkEnum(l,2,out v);
		o.renderMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isRootCanvas(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.isRootCanvas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCamera(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.worldCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldCamera(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.worldCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelRect(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.pixelRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleFactor(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.scaleFactor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleFactor(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.scaleFactor=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referencePixelsPerUnit(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.referencePixelsPerUnit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_referencePixelsPerUnit(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.referencePixelsPerUnit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overridePixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.overridePixelPerfect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overridePixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.overridePixelPerfect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.pixelPerfect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pixelPerfect(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.pixelPerfect=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_planeDistance(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.planeDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_planeDistance(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.planeDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderOrder(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.renderOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overrideSorting(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.overrideSorting);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overrideSorting(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.overrideSorting=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.sortingOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.sortingOrder=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerID(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.sortingLayerID);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerID(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.sortingLayerID=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayerName(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		pushValue(l,o.sortingLayerName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayerName(IntPtr l) {
		UnityEngine.Canvas o = (UnityEngine.Canvas)checkSelf(l);
		string v;
		checkType(l,2,out v);
		o.sortingLayerName=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Canvas");
		addMember(l,GetDefaultCanvasMaterial_s);
		addMember(l,GetDefaultCanvasTextMaterial_s);
		addMember(l,ForceUpdateCanvases_s);
		addMember(l,"renderMode",get_renderMode,set_renderMode,true);
		addMember(l,"isRootCanvas",get_isRootCanvas,null,true);
		addMember(l,"worldCamera",get_worldCamera,set_worldCamera,true);
		addMember(l,"pixelRect",get_pixelRect,null,true);
		addMember(l,"scaleFactor",get_scaleFactor,set_scaleFactor,true);
		addMember(l,"referencePixelsPerUnit",get_referencePixelsPerUnit,set_referencePixelsPerUnit,true);
		addMember(l,"overridePixelPerfect",get_overridePixelPerfect,set_overridePixelPerfect,true);
		addMember(l,"pixelPerfect",get_pixelPerfect,set_pixelPerfect,true);
		addMember(l,"planeDistance",get_planeDistance,set_planeDistance,true);
		addMember(l,"renderOrder",get_renderOrder,null,true);
		addMember(l,"overrideSorting",get_overrideSorting,set_overrideSorting,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"sortingLayerID",get_sortingLayerID,set_sortingLayerID,true);
		addMember(l,"sortingLayerName",get_sortingLayerName,set_sortingLayerName,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Canvas),typeof(UnityEngine.Behaviour));
	}
}
