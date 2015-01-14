using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.TextAsset o;
		if(matchType(l,1)){
			o=new UnityEngine.TextAsset();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		UnityEngine.TextAsset o = checkSelf<UnityEngine.TextAsset>(l);
		pushValue(l,o.text);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bytes(IntPtr l) {
		UnityEngine.TextAsset o = checkSelf<UnityEngine.TextAsset>(l);
		pushValue(l,o.bytes);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextAsset");
		addMember(l,get_text, "get_text");
		addMember(l,get_bytes, "get_bytes");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.TextAsset),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
