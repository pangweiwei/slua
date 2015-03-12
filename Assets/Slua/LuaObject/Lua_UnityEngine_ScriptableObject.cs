using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ScriptableObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ScriptableObject o;
		o=new UnityEngine.ScriptableObject();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateInstance_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.ScriptableObject ret=UnityEngine.ScriptableObject.CreateInstance(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.ScriptableObject ret=UnityEngine.ScriptableObject.CreateInstance(a1);
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
		getTypeTable(l,"UnityEngine.ScriptableObject");
		addMember(l,CreateInstance_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ScriptableObject),typeof(UnityEngine.Object));
	}
}
