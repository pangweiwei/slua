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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int foo(IntPtr l) {
		try{
			HelloWorld self=checkSelf<HelloWorld>(l);
			Dictionary<System.String,UnityEngine.GameObject> ret=self.foo();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int perf(IntPtr l) {
		try{
			HelloWorld self=checkSelf<HelloWorld>(l);
			self.perf();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int testvec3(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			HelloWorld.testvec3(a1);
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
		addMember(l,foo, "foo");
		addMember(l,perf, "perf");
		addMember(l,testvec3, "testvec3");
		newType(l, constructor);
		createTypeMetatable(l, typeof(HelloWorld));
		LuaDLL.lua_pop(l, 1);
	}
}
