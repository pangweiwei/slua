using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvStat_Identifier : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"InvStat.Identifier");
		addMember(l,0,"Strength");
		addMember(l,1,"Constitution");
		addMember(l,2,"Agility");
		addMember(l,3,"Intelligence");
		addMember(l,4,"Damage");
		addMember(l,5,"Crit");
		addMember(l,6,"Armor");
		addMember(l,7,"Health");
		addMember(l,8,"Mana");
		addMember(l,9,"Other");
		LuaDLL.lua_pop(l, 1);
	}
}
