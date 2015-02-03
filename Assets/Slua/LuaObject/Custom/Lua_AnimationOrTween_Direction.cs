using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AnimationOrTween_Direction : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"AnimationOrTween.Direction");
		addMember(l,-1,"Reverse");
		addMember(l,0,"Toggle");
		addMember(l,1,"Forward");
		LuaDLL.lua_pop(l, 1);
	}
}
