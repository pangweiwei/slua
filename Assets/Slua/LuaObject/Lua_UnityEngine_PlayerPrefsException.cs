using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PlayerPrefsException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.PlayerPrefsException o;
		System.String a1;
		checkType(l,2,out a1);
		o=new UnityEngine.PlayerPrefsException(a1);
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlayerPrefsException");
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlayerPrefsException));
	}
}
