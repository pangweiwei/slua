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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int foo(IntPtr l) {
		try{
			HelloWorld self=(HelloWorld)checkSelf(l);
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
	static public int getList(IntPtr l) {
		try{
			HelloWorld self=(HelloWorld)checkSelf(l);
			List<UnityEngine.GameObject> ret=self.getList();
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
			HelloWorld self=(HelloWorld)checkSelf(l);
			self.perf();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int say_s(IntPtr l) {
		try{
			HelloWorld.say();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setv_s(IntPtr l) {
		try{
			SLua.LuaTable a1;
			checkType(l,1,out a1);
			HelloWorld.setv(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int getv_s(IntPtr l) {
		try{
			SLua.LuaTable ret=HelloWorld.getv();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ofunc_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				HelloWorld.ofunc(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				HelloWorld.ofunc(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int testvec3_s(IntPtr l) {
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int testset_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			HelloWorld.testset(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int test2_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			HelloWorld.test2(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int test3_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			HelloWorld.test3(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int test4_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			HelloWorld.test4(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int test5_s(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			HelloWorld.test5(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int func6_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Object[] a2;
			checkParams(l,2,out a2);
			HelloWorld.func6(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"HelloWorld");
		addMember(l,foo);
		addMember(l,getList);
		addMember(l,perf);
		addMember(l,say_s);
		addMember(l,setv_s);
		addMember(l,getv_s);
		addMember(l,ofunc_s);
		addMember(l,testvec3_s);
		addMember(l,testset_s);
		addMember(l,test2_s);
		addMember(l,test3_s);
		addMember(l,test4_s);
		addMember(l,test5_s);
		addMember(l,func6_s);
		createTypeMetatable(l,constructor, typeof(HelloWorld));
	}
}
