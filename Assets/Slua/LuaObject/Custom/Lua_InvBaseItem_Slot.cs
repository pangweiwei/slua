using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvBaseItem_Slot : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"InvBaseItem.Slot");
		addMember(l,0,"None");
		addMember(l,1,"Weapon");
		addMember(l,2,"Shield");
		addMember(l,3,"Body");
		addMember(l,4,"Shoulders");
		addMember(l,5,"Bracers");
		addMember(l,6,"Boots");
		addMember(l,7,"Trinket");
		addMember(l,8,"_LastDoNotUse");
		LuaDLL.lua_pop(l, 1);
	}
}
