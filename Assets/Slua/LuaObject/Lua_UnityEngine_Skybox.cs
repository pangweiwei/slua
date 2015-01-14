using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Skybox : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Skybox o;
		if(matchType(l,1)){
			o=new UnityEngine.Skybox();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Skybox o = checkSelf<UnityEngine.Skybox>(l);
		pushValue(l,o.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Skybox o = checkSelf<UnityEngine.Skybox>(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		o.material=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Skybox");
		addMember(l,get_material, "get_material");
		addMember(l,set_material, "set_material");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Skybox),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
