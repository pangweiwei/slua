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
			UnityEngine.RectTransform self=(UnityEngine.RectTransform)checkSelf(l);
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
			UnityEngine.RectTransform self=(UnityEngine.RectTransform)checkSelf(l);
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
			UnityEngine.RectTransform self=(UnityEngine.RectTransform)checkSelf(l);
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
			UnityEngine.RectTransform self=(UnityEngine.RectTransform)checkSelf(l);
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
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.rect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchorMin(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.anchorMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchorMin(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchorMin=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchorMax(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.anchorMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchorMax(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchorMax=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchoredPosition3D(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.anchoredPosition3D);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchoredPosition3D(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.anchoredPosition3D=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchoredPosition(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.anchoredPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchoredPosition(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.anchoredPosition=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sizeDelta(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.sizeDelta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sizeDelta(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.sizeDelta=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.pivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pivot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetMin(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.offsetMin);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetMin(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.offsetMin=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetMax(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		pushValue(l,o.offsetMax);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetMax(IntPtr l) {
		UnityEngine.RectTransform o = (UnityEngine.RectTransform)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.offsetMax=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RectTransform");
		addMember(l,GetLocalCorners);
		addMember(l,GetWorldCorners);
		addMember(l,SetInsetAndSizeFromParentEdge);
		addMember(l,SetSizeWithCurrentAnchors);
		addMember(l,"rect",get_rect,null);
		addMember(l,"anchorMin",get_anchorMin,set_anchorMin);
		addMember(l,"anchorMax",get_anchorMax,set_anchorMax);
		addMember(l,"anchoredPosition3D",get_anchoredPosition3D,set_anchoredPosition3D);
		addMember(l,"anchoredPosition",get_anchoredPosition,set_anchoredPosition);
		addMember(l,"sizeDelta",get_sizeDelta,set_sizeDelta);
		addMember(l,"pivot",get_pivot,set_pivot);
		addMember(l,"offsetMin",get_offsetMin,set_offsetMin);
		addMember(l,"offsetMax",get_offsetMax,set_offsetMax);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RectTransform),typeof(UnityEngine.Transform));
	}
}
