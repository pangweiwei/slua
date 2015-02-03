using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvStat_Modifier : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"InvStat.Modifier");
		addMember(l,0,"Added");
		addMember(l,1,"Percent");
		LuaDLL.lua_pop(l, 1);
	}
}
