using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_PointerInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointerOverGameObject(IntPtr l) {
		try{
			UnityEngine.EventSystems.PointerInputModule self=checkSelf<UnityEngine.EventSystems.PointerInputModule>(l);
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
		addMember(l,IsPointerOverGameObject, "IsPointerOverGameObject");
		addMember(l,get_kMouseLeftId, "get_kMouseLeftId");
		addMember(l,get_kMouseRightId, "get_kMouseRightId");
		addMember(l,get_kMouseMiddleId, "get_kMouseMiddleId");
		addMember(l,get_kFakeTouchesId, "get_kFakeTouchesId");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.PointerInputModule),typeof(UnityEngine.EventSystems.BaseInputModule));
		LuaDLL.lua_pop(l, 1);
	}
}
