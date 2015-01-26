using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Image_Origin90 : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.UI.Image.Origin90");
		addMember(l,0,"BottomLeft");
		addMember(l,1,"TopLeft");
		addMember(l,2,"TopRight");
		addMember(l,3,"BottomRight");
		LuaDLL.lua_pop(l, 1);
	}
}
