using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_FixedJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.FixedJoint o;
		o=new UnityEngine.FixedJoint();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.FixedJoint");
		createTypeMetatable(l,constructor, typeof(UnityEngine.FixedJoint),typeof(UnityEngine.Joint));
	}
}
