using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RuntimeAnimatorController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.RuntimeAnimatorController o;
		o=new UnityEngine.RuntimeAnimatorController();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RuntimeAnimatorController");
		createTypeMetatable(l,constructor, typeof(UnityEngine.RuntimeAnimatorController),typeof(UnityEngine.Object));
	}
}
