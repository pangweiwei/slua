using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_SLuaTest : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"SLuaTest");
		createTypeMetatable(l,null, typeof(SLuaTest),typeof(UnityEngine.MonoBehaviour));
	}
}
