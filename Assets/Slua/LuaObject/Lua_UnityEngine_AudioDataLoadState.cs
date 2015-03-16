using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioDataLoadState : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AudioDataLoadState");
		addMember(l,0,"Unloaded");
		addMember(l,1,"Loading");
		addMember(l,2,"Loaded");
		addMember(l,3,"Failed");
		LuaDLL.lua_pop(l, 1);
	}
}
