using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_FixedJoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.FixedJoint o;
		if(matchType(l,1)){
			o=new UnityEngine.FixedJoint();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.FixedJoint");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.FixedJoint),typeof(UnityEngine.Joint));
		LuaDLL.lua_pop(l, 1);
	}
}
