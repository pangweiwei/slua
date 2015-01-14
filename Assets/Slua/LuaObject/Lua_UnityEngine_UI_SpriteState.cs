using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_SpriteState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = checkSelf<UnityEngine.UI.SpriteState>(l);
		pushValue(l,o.highlightedSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = checkSelf<UnityEngine.UI.SpriteState>(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.highlightedSprite=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = checkSelf<UnityEngine.UI.SpriteState>(l);
		pushValue(l,o.pressedSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = checkSelf<UnityEngine.UI.SpriteState>(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.pressedSprite=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = checkSelf<UnityEngine.UI.SpriteState>(l);
		pushValue(l,o.disabledSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = checkSelf<UnityEngine.UI.SpriteState>(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.disabledSprite=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.SpriteState");
		addMember(l,get_highlightedSprite, "get_highlightedSprite");
		addMember(l,set_highlightedSprite, "set_highlightedSprite");
		addMember(l,get_pressedSprite, "get_pressedSprite");
		addMember(l,set_pressedSprite, "set_pressedSprite");
		addMember(l,get_disabledSprite, "get_disabledSprite");
		addMember(l,set_disabledSprite, "set_disabledSprite");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.SpriteState));
		LuaDLL.lua_pop(l, 1);
	}
}
