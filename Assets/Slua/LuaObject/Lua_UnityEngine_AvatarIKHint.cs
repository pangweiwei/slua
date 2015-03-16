using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AvatarIKHint : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AvatarIKHint");
		addMember(l,0,"LeftKnee");
		addMember(l,1,"RightKnee");
		addMember(l,2,"LeftElbow");
		addMember(l,3,"RightElbow");
		LuaDLL.lua_pop(l, 1);
	}
}
