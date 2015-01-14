using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SpriteRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SpriteRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.SpriteRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		UnityEngine.SpriteRenderer o = checkSelf<UnityEngine.SpriteRenderer>(l);
		pushValue(l,o.sprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		UnityEngine.SpriteRenderer o = checkSelf<UnityEngine.SpriteRenderer>(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.sprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.SpriteRenderer o = checkSelf<UnityEngine.SpriteRenderer>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.SpriteRenderer o = checkSelf<UnityEngine.SpriteRenderer>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SpriteRenderer");
		addMember(l,get_sprite, "get_sprite");
		addMember(l,set_sprite, "set_sprite");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.SpriteRenderer),typeof(UnityEngine.Renderer));
		LuaDLL.lua_pop(l, 1);
	}
}
