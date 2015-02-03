using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UICenterOnClick : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UICenterOnClick o;
		o=new UICenterOnClick();
		pushObject(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UICenterOnClick");
		createTypeMetatable(l,constructor, typeof(UICenterOnClick),typeof(UnityEngine.MonoBehaviour));
	}
}
