using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderTextureFormat : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.RenderTextureFormat o = (UnityEngine.RenderTextureFormat)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.RenderTextureFormat");
		addMember(l,0,"ARGB32");
		addMember(l,1,"Depth");
		addMember(l,2,"ARGBHalf");
		addMember(l,4,"RGB565");
		addMember(l,5,"ARGB4444");
		addMember(l,6,"ARGB1555");
		addMember(l,7,"Default");
		addMember(l,9,"DefaultHDR");
		addMember(l,11,"ARGBFloat");
		addMember(l,12,"RGFloat");
		addMember(l,13,"RGHalf");
		addMember(l,14,"RFloat");
		addMember(l,15,"RHalf");
		addMember(l,16,"R8");
		addMember(l,17,"ARGBInt");
		addMember(l,18,"RGInt");
		addMember(l,19,"RInt");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
