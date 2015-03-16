using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PhysicsUpdateBehaviour2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.PhysicsUpdateBehaviour2D o;
		o=new UnityEngine.PhysicsUpdateBehaviour2D();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PhysicsUpdateBehaviour2D");
		createTypeMetatable(l,constructor, typeof(UnityEngine.PhysicsUpdateBehaviour2D),typeof(UnityEngine.Behaviour));
	}
}
