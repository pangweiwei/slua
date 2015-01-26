using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SendMessageOptions : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.SendMessageOptions");
		addMember(l,0,"RequireReceiver");
		addMember(l,1,"DontRequireReceiver");
		LuaDLL.lua_pop(l, 1);
	}
}
