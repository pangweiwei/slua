using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Avatar : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Avatar o;
		o=new UnityEngine.Avatar();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UnityEngine.Avatar o = (UnityEngine.Avatar)checkSelf(l);
		pushValue(l,o.isValid);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isHuman(IntPtr l) {
		UnityEngine.Avatar o = (UnityEngine.Avatar)checkSelf(l);
		pushValue(l,o.isHuman);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Avatar");
		addMember(l,"isValid",get_isValid,null,true);
		addMember(l,"isHuman",get_isHuman,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Avatar),typeof(UnityEngine.Object));
	}
}
