using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Image_Origin180 : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.Image.Origin180");
		addMember(l,0,"Bottom");
		addMember(l,1,"Left");
		addMember(l,2,"Top");
		addMember(l,3,"Right");
		LuaDLL.lua_pop(l, 1);
	}
}
