using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIInputOnGUI : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIInputOnGUI o;
		o=new UIInputOnGUI();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIInputOnGUI");
		createTypeMetatable(l,constructor, typeof(UIInputOnGUI),typeof(UnityEngine.MonoBehaviour));
	}
}
