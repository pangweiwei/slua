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
			HelloWorld.say();
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
	static public int setv(IntPtr l) {
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
	static public int getv(IntPtr l) {
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
	static public int callD(IntPtr l) {
		try{
			HelloWorld self=(HelloWorld)checkSelf(l);
			self.callD();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int generic(IntPtr l) {
		try{
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int testset(IntPtr l) {
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
	static public int get_d(IntPtr l) {
		HelloWorld o = (HelloWorld)checkSelf(l);
		pushValue(l,o.d);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_d(IntPtr l) {
		HelloWorld o = (HelloWorld)checkSelf(l);
		HelloWorld.GetBundleInfoDelegate v;
		checkDelegate(l,2,out v);
		o.d=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_s(IntPtr l) {
		HelloWorld o = (HelloWorld)checkSelf(l);
		pushValue(l,o.s);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_s(IntPtr l) {
		HelloWorld o = (HelloWorld)checkSelf(l);
		HelloWorld.SimpleDelegate v;
		checkDelegate(l,2,out v);
		o.s=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"HelloWorld");
		addMember(l,say);
		addMember(l,foo);
		addMember(l,setv);
		addMember(l,getv);
		addMember(l,callD);
		addMember(l,generic);
		addMember(l,perf);
		addMember(l,testvec3);
		addMember(l,testset);
		addMember(l,"d",get_d,set_d);
		addMember(l,"s",get_s,set_s);
		createTypeMetatable(l,constructor, typeof(HelloWorld));
	}
}
