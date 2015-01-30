using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MissingComponentException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.MissingComponentException o;
		if(matchType(l,1)){
			o=new UnityEngine.MissingComponentException();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(string))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.MissingComponentException(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(string),typeof(System.Exception))){
			System.String a1;
			checkType(l,1,out a1);
			System.Exception a2;
			checkType(l,2,out a2);
			o=new UnityEngine.MissingComponentException(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MissingComponentException");
		createTypeMetatable(l,constructor, typeof(UnityEngine.MissingComponentException));
	}
}
