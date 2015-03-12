using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ScaleMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ScaleMode");
		addMember(l,0,"StretchToFill");
		addMember(l,1,"ScaleAndCrop");
		addMember(l,2,"ScaleToFit");
		LuaDLL.lua_pop(l, 1);
	}
}
