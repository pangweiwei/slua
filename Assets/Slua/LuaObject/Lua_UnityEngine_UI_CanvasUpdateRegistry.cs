using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_CanvasUpdateRegistry : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterCanvasElementForLayoutRebuild(IntPtr l) {
		try{
			UnityEngine.UI.ICanvasElement a1;
			checkType(l,1,out a1);
			UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterCanvasElementForGraphicRebuild(IntPtr l) {
		try{
			UnityEngine.UI.ICanvasElement a1;
			checkType(l,1,out a1);
			UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnRegisterCanvasElementForRebuild(IntPtr l) {
		try{
			UnityEngine.UI.ICanvasElement a1;
			checkType(l,1,out a1);
			UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsRebuildingLayout(IntPtr l) {
		try{
			System.Boolean ret=UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingLayout();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsRebuildingGraphics(IntPtr l) {
		try{
			System.Boolean ret=UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingGraphics();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_instance(IntPtr l) {
		pushValue(l,UnityEngine.UI.CanvasUpdateRegistry.instance);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.CanvasUpdateRegistry");
		addMember(l,RegisterCanvasElementForLayoutRebuild);
		addMember(l,RegisterCanvasElementForGraphicRebuild);
		addMember(l,UnRegisterCanvasElementForRebuild);
		addMember(l,IsRebuildingLayout);
		addMember(l,IsRebuildingGraphics);
		addMember(l,"instance",get_instance,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.CanvasUpdateRegistry));
	}
}
