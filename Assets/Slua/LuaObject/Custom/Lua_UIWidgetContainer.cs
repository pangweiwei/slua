using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIWidgetContainer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIWidgetContainer o;
		o=new UIWidgetContainer();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIWidgetContainer");
		createTypeMetatable(l,constructor, typeof(UIWidgetContainer),typeof(UnityEngine.MonoBehaviour));
	}
}
