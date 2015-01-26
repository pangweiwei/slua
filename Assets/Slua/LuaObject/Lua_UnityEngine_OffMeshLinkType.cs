using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OffMeshLinkType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.OffMeshLinkType");
		addMember(l,0,"LinkTypeManual");
		addMember(l,1,"LinkTypeDropDown");
		addMember(l,2,"LinkTypeJumpAcross");
		LuaDLL.lua_pop(l, 1);
	}
}
