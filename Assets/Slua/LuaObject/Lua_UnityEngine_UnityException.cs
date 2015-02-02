using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UnityException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		UnityEngine.UnityException o;
		if(argc==1){
			o=new UnityEngine.UnityException();
			pushObject(l,o);
			return 1;
		}
		else if(argc==2){
			System.String a1;
			checkType(l,2,out a1);
			o=new UnityEngine.UnityException(a1);
			pushObject(l,o);
			return 1;
		}
		else if(argc==3){
			System.String a1;
			checkType(l,2,out a1);
			System.Exception a2;
			checkType(l,3,out a2);
			o=new UnityEngine.UnityException(a1,a2);
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UnityException");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UnityException));
	}
}
