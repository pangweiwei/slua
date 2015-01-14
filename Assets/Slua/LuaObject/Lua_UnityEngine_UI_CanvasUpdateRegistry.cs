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
		addMember(l,RegisterCanvasElementForLayoutRebuild, "RegisterCanvasElementForLayoutRebuild");
		addMember(l,RegisterCanvasElementForGraphicRebuild, "RegisterCanvasElementForGraphicRebuild");
		addMember(l,UnRegisterCanvasElementForRebuild, "UnRegisterCanvasElementForRebuild");
		addMember(l,IsRebuildingLayout, "IsRebuildingLayout");
		addMember(l,IsRebuildingGraphics, "IsRebuildingGraphics");
		addMember(l,get_instance, "get_instance");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.CanvasUpdateRegistry));
		LuaDLL.lua_pop(l, 1);
	}
}
