using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIOrthoCamera : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIOrthoCamera o;
		o=new UIOrthoCamera();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIOrthoCamera");
		createTypeMetatable(l,constructor, typeof(UIOrthoCamera),typeof(UnityEngine.MonoBehaviour));
	}
}
