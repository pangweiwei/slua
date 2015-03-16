﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PointerInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointerOverGameObject(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerInputModule self=(UnityEngine.EventSystems.PointerInputModule)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsPointerOverGameObject(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kMouseLeftId(IntPtr l) {
		pushValue(l,UnityEngine.EventSystems.PointerInputModule.kMouseLeftId);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kMouseRightId(IntPtr l) {
		pushValue(l,UnityEngine.EventSystems.PointerInputModule.kMouseRightId);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kMouseMiddleId(IntPtr l) {
		pushValue(l,UnityEngine.EventSystems.PointerInputModule.kMouseMiddleId);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kFakeTouchesId(IntPtr l) {
		pushValue(l,UnityEngine.EventSystems.PointerInputModule.kFakeTouchesId);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PointerInputModule");
		addMember(l,IsPointerOverGameObject);
		addMember(l,"kMouseLeftId",get_kMouseLeftId,null,false);
		addMember(l,"kMouseRightId",get_kMouseRightId,null,false);
		addMember(l,"kMouseMiddleId",get_kMouseMiddleId,null,false);
		addMember(l,"kFakeTouchesId",get_kFakeTouchesId,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.PointerInputModule),typeof(UnityEngine.EventSystems.BaseInputModule));
	}
}
