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
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClipPlane(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.nearClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClipPlane(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Single v;
		checkType(l,2,out v);
		o.nearClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClipPlane(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.farClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClipPlane(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Single v;
		checkType(l,2,out v);
		o.farClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fieldOfView(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.fieldOfView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fieldOfView(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Single v;
		checkType(l,2,out v);
		o.fieldOfView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectRatio(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.aspectRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectRatio(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Single v;
		checkType(l,2,out v);
		o.aspectRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOrthoGraphic(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.isOrthoGraphic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isOrthoGraphic(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.isOrthoGraphic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographic(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.orthographic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographic(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.orthographic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographicSize(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.orthographicSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographicSize(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Single v;
		checkType(l,2,out v);
		o.orthographicSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthoGraphicSize(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.orthoGraphicSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthoGraphicSize(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Single v;
		checkType(l,2,out v);
		o.orthoGraphicSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreLayers(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.ignoreLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreLayers(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.ignoreLayers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Projector o = checkSelf<UnityEngine.Projector>(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Projector");
		addMember(l,get_nearClipPlane, "get_nearClipPlane");
		addMember(l,set_nearClipPlane, "set_nearClipPlane");
		addMember(l,get_farClipPlane, "get_farClipPlane");
		addMember(l,set_farClipPlane, "set_farClipPlane");
		addMember(l,get_fieldOfView, "get_fieldOfView");
		addMember(l,set_fieldOfView, "set_fieldOfView");
		addMember(l,get_aspectRatio, "get_aspectRatio");
		addMember(l,set_aspectRatio, "set_aspectRatio");
		addMember(l,get_isOrthoGraphic, "get_isOrthoGraphic");
		addMember(l,set_isOrthoGraphic, "set_isOrthoGraphic");
		addMember(l,get_orthographic, "get_orthographic");
		addMember(l,set_orthographic, "set_orthographic");
		addMember(l,get_orthographicSize, "get_orthographicSize");
		addMember(l,set_orthographicSize, "set_orthographicSize");
		addMember(l,get_orthoGraphicSize, "get_orthoGraphicSize");
		addMember(l,set_orthoGraphicSize, "set_orthoGraphicSize");
		addMember(l,get_ignoreLayers, "get_ignoreLayers");
		addMember(l,set_ignoreLayers, "set_ignoreLayers");
		addMember(l,get_material, "get_material");
		addMember(l,set_material, "set_material");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Projector),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
