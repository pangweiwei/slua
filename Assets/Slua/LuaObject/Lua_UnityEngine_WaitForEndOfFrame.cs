using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WaitForEndOfFrame : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.WaitForEndOfFrame o;
		o=new UnityEngine.WaitForEndOfFrame();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WaitForEndOfFrame");
		createTypeMetatable(l,constructor, typeof(UnityEngine.WaitForEndOfFrame),typeof(UnityEngine.YieldInstruction));
	}
}
