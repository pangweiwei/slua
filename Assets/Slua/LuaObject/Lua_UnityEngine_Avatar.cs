using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Avatar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Avatar o;
		if(matchType(l,1)){
			o=new UnityEngine.Avatar();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UnityEngine.Avatar o = checkSelf<UnityEngine.Avatar>(l);
		pushValue(l,o.isValid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isHuman(IntPtr l) {
		UnityEngine.Avatar o = checkSelf<UnityEngine.Avatar>(l);
		pushValue(l,o.isHuman);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Avatar");
		addMember(l,get_isValid, "get_isValid");
		addMember(l,get_isHuman, "get_isHuman");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Avatar),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
