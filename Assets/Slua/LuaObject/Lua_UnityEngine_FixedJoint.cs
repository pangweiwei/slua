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
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.FixedJoint");
		createTypeMetatable(l,constructor, typeof(UnityEngine.FixedJoint),typeof(UnityEngine.Joint));
	}
}
