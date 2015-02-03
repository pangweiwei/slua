using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDrawCall_Clipping : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UIDrawCall.Clipping");
		addMember(l,0,"None");
		addMember(l,1,"TextureMask");
		addMember(l,3,"SoftClip");
		addMember(l,4,"ConstrainButDontClip");
		LuaDLL.lua_pop(l, 1);
	}
}
