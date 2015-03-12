﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SpriteRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.SpriteRenderer o;
		o=new UnityEngine.SpriteRenderer();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		UnityEngine.SpriteRenderer o = (UnityEngine.SpriteRenderer)checkSelf(l);
		pushValue(l,o.sprite);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		UnityEngine.SpriteRenderer o = (UnityEngine.SpriteRenderer)checkSelf(l);
		UnityEngine.Sprite v;
		checkType(l,2,out v);
		o.sprite=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.SpriteRenderer o = (UnityEngine.SpriteRenderer)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.SpriteRenderer o = (UnityEngine.SpriteRenderer)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SpriteRenderer");
		addMember(l,"sprite",get_sprite,set_sprite,true);
		addMember(l,"color",get_color,set_color,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SpriteRenderer),typeof(UnityEngine.Renderer));
	}
}
