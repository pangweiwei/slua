using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Flare : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Flare o;
		o=new UnityEngine.Flare();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Flare");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Flare),typeof(UnityEngine.Object));
	}
}
