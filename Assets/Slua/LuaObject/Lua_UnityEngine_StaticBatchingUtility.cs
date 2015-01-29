using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_StaticBatchingUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.StaticBatchingUtility o;
		if(matchType(l,1)){
			o=new UnityEngine.StaticBatchingUtility();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Combine_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				UnityEngine.StaticBatchingUtility.Combine(a1);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.GameObject[]),typeof(UnityEngine.GameObject))){
				UnityEngine.GameObject[] a1;
				checkType(l,1,out a1);
				UnityEngine.GameObject a2;
				checkType(l,2,out a2);
				UnityEngine.StaticBatchingUtility.Combine(a1,a2);
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.StaticBatchingUtility");
		addMember(l,Combine_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.StaticBatchingUtility));
	}
}
