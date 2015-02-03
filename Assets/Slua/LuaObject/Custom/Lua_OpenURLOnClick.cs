using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_OpenURLOnClick : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		OpenURLOnClick o;
		o=new OpenURLOnClick();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"OpenURLOnClick");
		createTypeMetatable(l,constructor, typeof(OpenURLOnClick),typeof(UnityEngine.MonoBehaviour));
	}
}
