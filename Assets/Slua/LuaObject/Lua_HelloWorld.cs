using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_HelloWorld : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		HelloWorld o;
		if(matchType(l,1)){
			o=new HelloWorld();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int say(IntPtr l) {
		try{
			HelloWorld self=checkSelf<HelloWorld>(l);
			self.say();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"HelloWorld");
		addMember(l,say, "say");
		newType(l, constructor);
		createTypeMetatable(l, typeof(HelloWorld));
		LuaDLL.lua_pop(l, 1);
	}
}
