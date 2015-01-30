using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PlayerPrefsException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.PlayerPrefsException o;
		if(matchType(l,1,typeof(string))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.PlayerPrefsException(a1);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlayerPrefsException");
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlayerPrefsException));
	}
}
