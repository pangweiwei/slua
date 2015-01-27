using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Projector : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Projector o;
		if(matchType(l,1)){
			o=new UnityEngine.Projector();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClipPlane(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.nearClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClipPlane(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.nearClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClipPlane(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.farClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClipPlane(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.farClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fieldOfView(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.fieldOfView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fieldOfView(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.fieldOfView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectRatio(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.aspectRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectRatio(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.aspectRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOrthoGraphic(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.isOrthoGraphic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isOrthoGraphic(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.isOrthoGraphic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographic(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.orthographic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographic(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.orthographic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographicSize(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.orthographicSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographicSize(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.orthographicSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthoGraphicSize(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.orthoGraphicSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthoGraphicSize(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.orthoGraphicSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreLayers(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.ignoreLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreLayers(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.ignoreLayers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Projector o = (UnityEngine.Projector)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Projector");
		addMember(l,"nearClipPlane",get_nearClipPlane,set_nearClipPlane,true);
		addMember(l,"farClipPlane",get_farClipPlane,set_farClipPlane,true);
		addMember(l,"fieldOfView",get_fieldOfView,set_fieldOfView,true);
		addMember(l,"aspectRatio",get_aspectRatio,set_aspectRatio,true);
		addMember(l,"isOrthoGraphic",get_isOrthoGraphic,set_isOrthoGraphic,true);
		addMember(l,"orthographic",get_orthographic,set_orthographic,true);
		addMember(l,"orthographicSize",get_orthographicSize,set_orthographicSize,true);
		addMember(l,"orthoGraphicSize",get_orthoGraphicSize,set_orthoGraphicSize,true);
		addMember(l,"ignoreLayers",get_ignoreLayers,set_ignoreLayers,true);
		addMember(l,"material",get_material,set_material,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Projector),typeof(UnityEngine.Behaviour));
	}
}
