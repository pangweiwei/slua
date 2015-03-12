using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WebCamDevice : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UnityEngine.WebCamDevice o = (UnityEngine.WebCamDevice)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isFrontFacing(IntPtr l) {
		UnityEngine.WebCamDevice o = (UnityEngine.WebCamDevice)checkSelf(l);
		pushValue(l,o.isFrontFacing);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WebCamDevice");
		addMember(l,"name",get_name,null,true);
		addMember(l,"isFrontFacing",get_isFrontFacing,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WebCamDevice));
	}
}
