using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DeviceType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.DeviceType");
		addMember(l,0,"Unknown");
		addMember(l,1,"Handheld");
		addMember(l,2,"Console");
		addMember(l,3,"Desktop");
		LuaDLL.lua_pop(l, 1);
	}
}
