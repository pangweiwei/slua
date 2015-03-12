using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WaitForFixedUpdate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.WaitForFixedUpdate o;
		o=new UnityEngine.WaitForFixedUpdate();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WaitForFixedUpdate");
		createTypeMetatable(l,constructor, typeof(UnityEngine.WaitForFixedUpdate),typeof(UnityEngine.YieldInstruction));
	}
}
