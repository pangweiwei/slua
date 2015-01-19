using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RectTransform : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.RectTransform o;
		if(matchType(l,1)){
			o=new UnityEngine.RectTransform();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLocalCorners(IntPtr l) {
		try{
			UnityEngine.RectTransform self=checkSelf<UnityEngine.RectTransform>(l);
			UnityEngine.Vector3[] a1;
			checkType(l,2,out a1);
			self.GetLocalCorners(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetWorldCorners(IntPtr l) {
		try{
			UnityEngine.RectTransform self=checkSelf<UnityEngine.RectTransform>(l);
			UnityEngine.Vector3[] a1;
			checkType(l,2,out a1);
			self.GetWorldCorners(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInsetAndSizeFromParentEdge(IntPtr l) {
		try{
			UnityEngine.RectTransform self=checkSelf<UnityEngine.RectTransform>(l);
			UnityEngine.RectTransform.Edge a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.SetInsetAndSizeFromParentEdge(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetSizeWithCurrentAnchors(IntPtr l) {
		try{
			UnityEngine.RectTransform self=checkSelf<UnityEngine.RectTransform>(l);
			UnityEngine.RectTransform.Axis a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetSizeWithCurrentAnchors(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rect(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.rect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchorMin(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.anchorMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchorMin(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchorMin=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchorMax(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.anchorMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchorMax(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchorMax=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchoredPosition3D(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.anchoredPosition3D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchoredPosition3D(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.anchoredPosition3D=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchoredPosition(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.anchoredPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchoredPosition(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchoredPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sizeDelta(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.sizeDelta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sizeDelta(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.sizeDelta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.pivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pivot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetMin(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.offsetMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetMin(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.offsetMin=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetMax(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		pushValue(l,o.offsetMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetMax(IntPtr l) {
		UnityEngine.RectTransform o = checkSelf<UnityEngine.RectTransform>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.offsetMax=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RectTransform");
		addMember(l,GetLocalCorners, "GetLocalCorners");
		addMember(l,GetWorldCorners, "GetWorldCorners");
		addMember(l,SetInsetAndSizeFromParentEdge, "SetInsetAndSizeFromParentEdge");
		addMember(l,SetSizeWithCurrentAnchors, "SetSizeWithCurrentAnchors");
		addMember(l,get_rect, "get_rect");
		addMember(l,get_anchorMin, "get_anchorMin");
		addMember(l,set_anchorMin, "set_anchorMin");
		addMember(l,get_anchorMax, "get_anchorMax");
		addMember(l,set_anchorMax, "set_anchorMax");
		addMember(l,get_anchoredPosition3D, "get_anchoredPosition3D");
		addMember(l,set_anchoredPosition3D, "set_anchoredPosition3D");
		addMember(l,get_anchoredPosition, "get_anchoredPosition");
		addMember(l,set_anchoredPosition, "set_anchoredPosition");
		addMember(l,get_sizeDelta, "get_sizeDelta");
		addMember(l,set_sizeDelta, "set_sizeDelta");
		addMember(l,get_pivot, "get_pivot");
		addMember(l,set_pivot, "set_pivot");
		addMember(l,get_offsetMin, "get_offsetMin");
		addMember(l,set_offsetMin, "set_offsetMin");
		addMember(l,get_offsetMax, "get_offsetMax");
		addMember(l,set_offsetMax, "set_offsetMax");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.RectTransform),typeof(UnityEngine.Transform));
		LuaDLL.lua_pop(l, 1);
	}
}
