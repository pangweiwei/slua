using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ShaderQuality : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		ShaderQuality o;
		o=new ShaderQuality();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ShaderQuality");
		createTypeMetatable(l,constructor, typeof(ShaderQuality),typeof(UnityEngine.MonoBehaviour));
	}
}
