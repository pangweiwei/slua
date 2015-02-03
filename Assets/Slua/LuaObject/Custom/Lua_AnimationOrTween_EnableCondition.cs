using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AnimationOrTween_EnableCondition : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"AnimationOrTween.EnableCondition");
		addMember(l,0,"DoNothing");
		addMember(l,1,"EnableThenPlay");
		addMember(l,2,"IgnoreDisabledState");
		LuaDLL.lua_pop(l, 1);
	}
}
