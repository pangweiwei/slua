using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_SpriteState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = (UnityEngine.UI.SpriteState)checkSelf(l);
		pushValue(l,o.highlightedSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = (UnityEngine.UI.SpriteState)checkSelf(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.highlightedSprite=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = (UnityEngine.UI.SpriteState)checkSelf(l);
		pushValue(l,o.pressedSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = (UnityEngine.UI.SpriteState)checkSelf(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.pressedSprite=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = (UnityEngine.UI.SpriteState)checkSelf(l);
		pushValue(l,o.disabledSprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledSprite(IntPtr l) {
		UnityEngine.UI.SpriteState o = (UnityEngine.UI.SpriteState)checkSelf(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.disabledSprite=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.SpriteState");
		addMember(l,"highlightedSprite",get_highlightedSprite,set_highlightedSprite);
		addMember(l,"pressedSprite",get_pressedSprite,set_pressedSprite);
		addMember(l,"disabledSprite",get_disabledSprite,set_disabledSprite);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.SpriteState));
	}
}
