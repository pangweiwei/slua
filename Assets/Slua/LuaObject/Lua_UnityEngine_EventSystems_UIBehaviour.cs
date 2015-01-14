using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_UIBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsActive(IntPtr l) {
		try{
			UnityEngine.EventSystems.UIBehaviour self=checkSelf<UnityEngine.EventSystems.UIBehaviour>(l);
			System.Boolean ret=self.IsActive();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsDestroyed(IntPtr l) {
		try{
			UnityEngine.EventSystems.UIBehaviour self=checkSelf<UnityEngine.EventSystems.UIBehaviour>(l);
			System.Boolean ret=self.IsDestroyed();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.UIBehaviour");
		addMember(l,IsActive, "IsActive");
		addMember(l,IsDestroyed, "IsDestroyed");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.EventSystems.UIBehaviour),typeof(UnityEngine.MonoBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
