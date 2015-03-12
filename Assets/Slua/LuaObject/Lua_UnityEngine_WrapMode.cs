using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WrapMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.WrapMode");
		addMember(l,1,"Once");
		addMember(l,2,"Loop");
		addMember(l,4,"PingPong");
		addMember(l,0,"Default");
		addMember(l,8,"ClampForever");
		addMember(l,1,"Clamp");
		LuaDLL.lua_pop(l, 1);
	}
}
