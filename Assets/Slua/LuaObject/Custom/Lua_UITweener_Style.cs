using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITweener_Style : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UITweener.Style");
		addMember(l,0,"Once");
		addMember(l,1,"Loop");
		addMember(l,2,"PingPong");
		LuaDLL.lua_pop(l, 1);
	}
}
