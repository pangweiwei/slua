using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Button_ButtonClickedEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.UI.Button.ButtonClickedEvent o;
		if(matchType(l,1)){
			o=new UnityEngine.UI.Button.ButtonClickedEvent();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Button.ButtonClickedEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Button.ButtonClickedEvent),typeof(UnityEngine.Events.UnityEvent));
	}
}
