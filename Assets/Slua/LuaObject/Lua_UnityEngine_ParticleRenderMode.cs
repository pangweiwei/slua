using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleRenderMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ParticleRenderMode o = (UnityEngine.ParticleRenderMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleRenderMode");
		addMember(l,0,"Billboard");
		addMember(l,3,"Stretch");
		addMember(l,2,"SortedBillboard");
		addMember(l,4,"HorizontalBillboard");
		addMember(l,5,"VerticalBillboard");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
