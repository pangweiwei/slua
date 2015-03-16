using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Toggle_ToggleEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.UI.Toggle.ToggleEvent o;
		o=new UnityEngine.UI.Toggle.ToggleEvent();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_bool.reg(l);
		getTypeTable(l,"UnityEngine.UI.Toggle.ToggleEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Toggle.ToggleEvent),typeof(LuaUnityEvent_bool));
	}
}
