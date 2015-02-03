using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_StaticBatchingUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.StaticBatchingUtility o;
		o=new UnityEngine.StaticBatchingUtility();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Combine_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.GameObject a1;
				checkType(l,1,out a1);
				UnityEngine.StaticBatchingUtility.Combine(a1);
				return 0;
			}
			else if(argc==2){
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
