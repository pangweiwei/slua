using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIRoot_Scaling : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIRoot.Scaling");
		addMember(l,0,"PixelPerfect");
		addMember(l,1,"FixedSize");
		addMember(l,2,"FixedSizeOnMobiles");
		LuaDLL.lua_pop(l, 1);
	}
}
