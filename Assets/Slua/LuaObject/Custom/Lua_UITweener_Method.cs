using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITweener_Method : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UITweener.Method");
		addMember(l,0,"Linear");
		addMember(l,1,"EaseIn");
		addMember(l,2,"EaseOut");
		addMember(l,3,"EaseInOut");
		addMember(l,4,"BounceIn");
		addMember(l,5,"BounceOut");
		LuaDLL.lua_pop(l, 1);
	}
}
