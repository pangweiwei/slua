using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISliderColors : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UISliderColors o;
		o=new UISliderColors();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		UISliderColors o = (UISliderColors)checkSelf(l);
		pushValue(l,o.sprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		UISliderColors o = (UISliderColors)checkSelf(l);
		UISprite v;
		checkType(l,2,out v);
		o.sprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colors(IntPtr l) {
		UISliderColors o = (UISliderColors)checkSelf(l);
		pushValue(l,o.colors);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colors(IntPtr l) {
		UISliderColors o = (UISliderColors)checkSelf(l);
		UnityEngine.Color[] v;
		checkType(l,2,out v);
		o.colors=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISliderColors");
		addMember(l,"sprite",get_sprite,set_sprite,true);
		addMember(l,"colors",get_colors,set_colors,true);
		createTypeMetatable(l,constructor, typeof(UISliderColors),typeof(UnityEngine.MonoBehaviour));
	}
}
