using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvGameItem_Quality : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"InvGameItem.Quality");
		addMember(l,0,"Broken");
		addMember(l,1,"Cursed");
		addMember(l,2,"Damaged");
		addMember(l,3,"Worn");
		addMember(l,4,"Sturdy");
		addMember(l,5,"Polished");
		addMember(l,6,"Improved");
		addMember(l,7,"Crafted");
		addMember(l,8,"Superior");
		addMember(l,9,"Enchanted");
		addMember(l,10,"Epic");
		addMember(l,11,"Legendary");
		addMember(l,12,"_LastDoNotUse");
		LuaDLL.lua_pop(l, 1);
	}
}
