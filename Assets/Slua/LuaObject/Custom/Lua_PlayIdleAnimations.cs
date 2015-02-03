using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PlayIdleAnimations : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		PlayIdleAnimations o;
		o=new PlayIdleAnimations();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"PlayIdleAnimations");
		createTypeMetatable(l,constructor, typeof(PlayIdleAnimations),typeof(UnityEngine.MonoBehaviour));
	}
}
