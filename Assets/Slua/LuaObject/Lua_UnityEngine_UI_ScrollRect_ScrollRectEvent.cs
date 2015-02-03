using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.UI.ScrollRect.ScrollRectEvent o;
		o=new UnityEngine.UI.ScrollRect.ScrollRectEvent();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_UnityEngine_Vector2.reg(l);
		getTypeTable(l,"UnityEngine.UI.ScrollRect.ScrollRectEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent),typeof(LuaUnityEvent_UnityEngine_Vector2));
	}
}
