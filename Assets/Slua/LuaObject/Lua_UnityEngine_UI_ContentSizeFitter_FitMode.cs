using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ContentSizeFitter_FitMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.ContentSizeFitter.FitMode");
		addMember(l,0,"Unconstrained");
		addMember(l,1,"MinSize");
		addMember(l,2,"PreferredSize");
		LuaDLL.lua_pop(l, 1);
	}
}
