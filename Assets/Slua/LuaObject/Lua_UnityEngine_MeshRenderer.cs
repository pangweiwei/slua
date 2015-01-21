using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.MeshRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.MeshRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshRenderer");
		createTypeMetatable(l,constructor, typeof(UnityEngine.MeshRenderer),typeof(UnityEngine.Renderer));
	}
}
