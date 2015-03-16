using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ApplicationSandboxType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ApplicationSandboxType");
		addMember(l,0,"Unknown");
		addMember(l,1,"NotSandboxed");
		addMember(l,2,"Sandboxed");
		addMember(l,3,"SandboxBroken");
		LuaDLL.lua_pop(l, 1);
	}
}
