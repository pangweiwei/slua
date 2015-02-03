using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIAnchor_Side : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIAnchor.Side");
		addMember(l,0,"BottomLeft");
		addMember(l,1,"Left");
		addMember(l,2,"TopLeft");
		addMember(l,3,"Top");
		addMember(l,4,"TopRight");
		addMember(l,5,"Right");
		addMember(l,6,"BottomRight");
		addMember(l,7,"Bottom");
		addMember(l,8,"Center");
		LuaDLL.lua_pop(l, 1);
	}
}
