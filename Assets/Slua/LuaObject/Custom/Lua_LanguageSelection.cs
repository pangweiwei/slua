using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LanguageSelection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LanguageSelection o;
		o=new LanguageSelection();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LanguageSelection");
		createTypeMetatable(l,constructor, typeof(LanguageSelection),typeof(UnityEngine.MonoBehaviour));
	}
}
