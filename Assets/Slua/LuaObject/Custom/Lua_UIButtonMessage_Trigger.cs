using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonMessage_Trigger : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIButtonMessage.Trigger");
		addMember(l,0,"OnClick");
		addMember(l,1,"OnMouseOver");
		addMember(l,2,"OnMouseOut");
		addMember(l,3,"OnPress");
		addMember(l,4,"OnRelease");
		addMember(l,5,"OnDoubleClick");
		LuaDLL.lua_pop(l, 1);
	}
}
