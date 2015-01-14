using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_PositionAsUV1 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ModifyVertices(IntPtr l) {
		try{
			UnityEngine.UI.PositionAsUV1 self=checkSelf<UnityEngine.UI.PositionAsUV1>(l);
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
		getTypeTable(l,"UnityEngine.UI.PositionAsUV1");
		addMember(l,ModifyVertices, "ModifyVertices");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.PositionAsUV1),typeof(UnityEngine.UI.BaseVertexEffect));
		LuaDLL.lua_pop(l, 1);
	}
}
