using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ContentSizeFitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		try{
			UnityEngine.UI.ContentSizeFitter self=(UnityEngine.UI.ContentSizeFitter)checkSelf(l);
			self.SetLayoutHorizontal();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutVertical(IntPtr l) {
		try{
			UnityEngine.UI.ContentSizeFitter self=(UnityEngine.UI.ContentSizeFitter)checkSelf(l);
			self.SetLayoutVertical();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = (UnityEngine.UI.ContentSizeFitter)checkSelf(l);
		pushEnum(l,(int)o.horizontalFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = (UnityEngine.UI.ContentSizeFitter)checkSelf(l);
		UnityEngine.UI.ContentSizeFitter.FitMode v;
		checkEnum(l,2,out v);
		o.horizontalFit=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = (UnityEngine.UI.ContentSizeFitter)checkSelf(l);
		pushEnum(l,(int)o.verticalFit);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalFit(IntPtr l) {
		UnityEngine.UI.ContentSizeFitter o = (UnityEngine.UI.ContentSizeFitter)checkSelf(l);
		UnityEngine.UI.ContentSizeFitter.FitMode v;
		checkEnum(l,2,out v);
		o.verticalFit=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ContentSizeFitter");
		addMember(l,SetLayoutHorizontal);
		addMember(l,SetLayoutVertical);
		addMember(l,"horizontalFit",get_horizontalFit,set_horizontalFit,true);
		addMember(l,"verticalFit",get_verticalFit,set_verticalFit,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.ContentSizeFitter),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
