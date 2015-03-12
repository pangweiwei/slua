﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Skybox : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Skybox o;
		o=new UnityEngine.Skybox();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Skybox o = (UnityEngine.Skybox)checkSelf(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Skybox o = (UnityEngine.Skybox)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Skybox");
		addMember(l,"material",get_material,set_material,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Skybox),typeof(UnityEngine.Behaviour));
	}
}
