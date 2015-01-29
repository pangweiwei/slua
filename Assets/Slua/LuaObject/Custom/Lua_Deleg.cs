using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Deleg : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		Deleg o;
		if(matchType(l,1)){
			o=new Deleg();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int testFunc_s(IntPtr l) {
		try{
			System.Func<System.Int32> a1;
			checkDelegate(l,1,out a1);
			Deleg.testFunc(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int testAction_s(IntPtr l) {
		try{
			System.Action<System.Int32,System.String> a1;
			checkDelegate(l,1,out a1);
			Deleg.testAction(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int testDAction_s(IntPtr l) {
		try{
			System.Action<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Object>> a1;
			checkDelegate(l,1,out a1);
			Deleg.testDAction(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int callDAction_s(IntPtr l) {
		try{
			Deleg.callDAction();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_daction(IntPtr l) {
		System.Action<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Object>> v;
		int op=checkDelegate(l,2,out v);
		if(op==0) Deleg.daction=v;
		else if(op==1) Deleg.daction+=v;
		else if(op==2) Deleg.daction-=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Deleg");
		addMember(l,testFunc_s);
		addMember(l,testAction_s);
		addMember(l,testDAction_s);
		addMember(l,callDAction_s);
		addMember(l,"daction",null,set_daction,false);
		createTypeMetatable(l,constructor, typeof(Deleg),typeof(UnityEngine.MonoBehaviour));
	}
}
