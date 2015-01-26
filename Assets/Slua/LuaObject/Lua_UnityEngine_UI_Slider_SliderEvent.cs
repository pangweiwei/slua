using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Slider_SliderEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.UI.Slider.SliderEvent o;
		if(matchType(l,1)){
			o=new UnityEngine.UI.Slider.SliderEvent();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_Single.reg(l);
		getTypeTable(l,"UnityEngine.UI.Slider.SliderEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.Slider.SliderEvent));
	}
}
