using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleRenderMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleRenderMode");
		addMember(l,0,"Billboard");
		addMember(l,3,"Stretch");
		addMember(l,2,"SortedBillboard");
		addMember(l,4,"HorizontalBillboard");
		addMember(l,5,"VerticalBillboard");
		LuaDLL.lua_pop(l, 1);
	}
}
