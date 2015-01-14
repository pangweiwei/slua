using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_BaseVertexEffect : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ModifyVertices(IntPtr l) {
		try{
			UnityEngine.UI.BaseVertexEffect self=checkSelf<UnityEngine.UI.BaseVertexEffect>(l);
			List<UnityEngine.UIVertex> a1;
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
		addMember(l,ModifyVertices, "ModifyVertices");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.BaseVertexEffect),typeof(UnityEngine.EventSystems.UIBehaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
