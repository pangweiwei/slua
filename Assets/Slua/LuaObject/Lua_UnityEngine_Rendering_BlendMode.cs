using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_BlendMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.Rendering.BlendMode o = (UnityEngine.Rendering.BlendMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.BlendMode");
		addMember(l,0,"Zero");
		addMember(l,1,"One");
		addMember(l,2,"DstColor");
		addMember(l,3,"SrcColor");
		addMember(l,4,"OneMinusDstColor");
		addMember(l,5,"SrcAlpha");
		addMember(l,6,"OneMinusSrcColor");
		addMember(l,7,"DstAlpha");
		addMember(l,8,"OneMinusDstAlpha");
		addMember(l,9,"SrcAlphaSaturate");
		addMember(l,10,"OneMinusSrcAlpha");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
