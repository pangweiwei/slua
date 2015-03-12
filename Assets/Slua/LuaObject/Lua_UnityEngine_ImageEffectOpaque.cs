using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ImageEffectOpaque : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ImageEffectOpaque o;
		o=new UnityEngine.ImageEffectOpaque();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ImageEffectOpaque");
		createTypeMetatable(l,constructor, typeof(UnityEngine.ImageEffectOpaque));
	}
}
