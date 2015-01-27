using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Custom : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		Custom o;
		if(matchType(l,1)){
			o=new Custom();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Custom");
		addMember(l,Custom.instanceCustom,true);
		addMember(l,Custom.staticCustom,false);
		createTypeMetatable(l,constructor, typeof(Custom),typeof(UnityEngine.MonoBehaviour));
	}
}
