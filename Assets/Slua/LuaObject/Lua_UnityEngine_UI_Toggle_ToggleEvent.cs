using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Toggle_ToggleEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.UI.Toggle.ToggleEvent o;
		if(matchType(l,1)){
			o=new UnityEngine.UI.Toggle.ToggleEvent();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_bool.reg(l);
		getTypeTable(l,"UnityEngine.UI.Toggle.ToggleEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Toggle.ToggleEvent));
	}
}
