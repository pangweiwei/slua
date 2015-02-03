using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIPlaySound_Trigger : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIPlaySound.Trigger");
		addMember(l,0,"OnClick");
		addMember(l,1,"OnMouseOver");
		addMember(l,2,"OnMouseOut");
		addMember(l,3,"OnPress");
		addMember(l,4,"OnRelease");
		addMember(l,5,"Custom");
		addMember(l,6,"OnEnable");
		addMember(l,7,"OnDisable");
		LuaDLL.lua_pop(l, 1);
	}
}
