using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemRenderMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.ParticleSystemRenderMode o = (UnityEngine.ParticleSystemRenderMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemRenderMode");
		addMember(l,0,"Billboard");
		addMember(l,1,"Stretch");
		addMember(l,2,"HorizontalBillboard");
		addMember(l,3,"VerticalBillboard");
		addMember(l,4,"Mesh");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
