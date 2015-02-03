﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_BaseVertexEffect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ModifyVertices(IntPtr l) {
		try{
			UnityEngine.UI.BaseVertexEffect self=(UnityEngine.UI.BaseVertexEffect)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,2,out a1);
			self.ModifyVertices(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.BaseVertexEffect");
		addMember(l,ModifyVertices);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.BaseVertexEffect),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
