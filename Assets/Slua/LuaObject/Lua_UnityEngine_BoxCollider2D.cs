﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BoxCollider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.BoxCollider2D o;
		o=new UnityEngine.BoxCollider2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.BoxCollider2D o = (UnityEngine.BoxCollider2D)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.BoxCollider2D o = (UnityEngine.BoxCollider2D)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.size=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BoxCollider2D");
		addMember(l,"size",get_size,set_size,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.BoxCollider2D),typeof(UnityEngine.Collider2D));
	}
}
