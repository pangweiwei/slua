using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.MeshRenderer o;
		o=new UnityEngine.MeshRenderer();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshRenderer");
		createTypeMetatable(l,constructor, typeof(UnityEngine.MeshRenderer),typeof(UnityEngine.Renderer));
	}
}
