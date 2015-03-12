using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_DepthTextureMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.DepthTextureMode");
		addMember(l,0,"None");
		addMember(l,1,"Depth");
		addMember(l,2,"DepthNormals");
		LuaDLL.lua_pop(l, 1);
	}
}
