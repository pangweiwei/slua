using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CanvasGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.CanvasGroup o;
		if(matchType(l,1)){
			o=new UnityEngine.CanvasGroup();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsRaycastLocationValid(IntPtr l) {
		try{
			UnityEngine.CanvasGroup self=(UnityEngine.CanvasGroup)checkSelf(l);
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
	static public int get_alpha(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		pushValue(l,o.alpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.alpha=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interactable(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		pushValue(l,o.interactable);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interactable(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.interactable=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blocksRaycasts(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		pushValue(l,o.blocksRaycasts);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blocksRaycasts(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.blocksRaycasts=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreParentGroups(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		pushValue(l,o.ignoreParentGroups);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreParentGroups(IntPtr l) {
		UnityEngine.CanvasGroup o = (UnityEngine.CanvasGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.ignoreParentGroups=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CanvasGroup");
		addMember(l,IsRaycastLocationValid);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"interactable",get_interactable,set_interactable,true);
		addMember(l,"blocksRaycasts",get_blocksRaycasts,set_blocksRaycasts,true);
		addMember(l,"ignoreParentGroups",get_ignoreParentGroups,set_ignoreParentGroups,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CanvasGroup),typeof(UnityEngine.Component));
	}
}
