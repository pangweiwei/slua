using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SleepTimeout : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.SleepTimeout o;
		o=new UnityEngine.SleepTimeout();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_NeverSleep(IntPtr l) {
		pushValue(l,UnityEngine.SleepTimeout.NeverSleep);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_SystemSetting(IntPtr l) {
		pushValue(l,UnityEngine.SleepTimeout.SystemSetting);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SleepTimeout");
		addMember(l,"NeverSleep",get_NeverSleep,null,false);
		addMember(l,"SystemSetting",get_SystemSetting,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SleepTimeout));
	}
}
