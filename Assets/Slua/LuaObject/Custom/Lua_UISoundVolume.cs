using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISoundVolume : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UISoundVolume o;
		o=new UISoundVolume();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISoundVolume");
		createTypeMetatable(l,constructor, typeof(UISoundVolume),typeof(UnityEngine.MonoBehaviour));
	}
}
