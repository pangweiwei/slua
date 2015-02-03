using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIProgressBar_FillDirection : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIProgressBar.FillDirection");
		addMember(l,0,"LeftToRight");
		addMember(l,1,"RightToLeft");
		addMember(l,2,"BottomToTop");
		addMember(l,3,"TopToBottom");
		LuaDLL.lua_pop(l, 1);
	}
}
