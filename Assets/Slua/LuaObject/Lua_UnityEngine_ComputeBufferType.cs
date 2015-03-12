using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ComputeBufferType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ComputeBufferType");
		addMember(l,0,"Default");
		addMember(l,1,"Raw");
		addMember(l,2,"Append");
		addMember(l,4,"Counter");
		addMember(l,256,"DrawIndirect");
		LuaDLL.lua_pop(l, 1);
	}
}
