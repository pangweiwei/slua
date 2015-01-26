using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.AnimationInfo o = (UnityEngine.AnimationInfo)checkSelf(l);
		pushValue(l,o.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight(IntPtr l) {
		UnityEngine.AnimationInfo o = (UnityEngine.AnimationInfo)checkSelf(l);
		pushValue(l,o.weight);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationInfo");
		addMember(l,"clip",get_clip,null);
		addMember(l,"weight",get_weight,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimationInfo));
	}
}
