using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Security : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Security o;
		if(matchType(l,1)){
			o=new UnityEngine.Security();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAndVerifyAssembly_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Byte),typeof(System.String))){
				System.Byte[] a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Reflection.Assembly ret=UnityEngine.Security.LoadAndVerifyAssembly(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Byte))){
				System.Byte[] a1;
				checkType(l,1,out a1);
				System.Reflection.Assembly ret=UnityEngine.Security.LoadAndVerifyAssembly(a1);
				pushValue(l,ret);
				return 1;
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
	static public int PrefetchSocketPolicy_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String),typeof(System.Int32))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean ret=UnityEngine.Security.PrefetchSocketPolicy(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Int32),typeof(System.Int32))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Security.PrefetchSocketPolicy(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Security");
		addMember(l,LoadAndVerifyAssembly_s);
		addMember(l,PrefetchSocketPolicy_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Security));
	}
}
