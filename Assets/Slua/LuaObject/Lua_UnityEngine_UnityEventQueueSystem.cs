using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UnityEventQueueSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.UnityEventQueueSystem o;
		o=new UnityEngine.UnityEventQueueSystem();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GenerateEventIdForPayload_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.String ret=UnityEngine.UnityEventQueueSystem.GenerateEventIdForPayload(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGlobalEventQueue_s(IntPtr l) {
		try{
			System.IntPtr ret=UnityEngine.UnityEventQueueSystem.GetGlobalEventQueue();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UnityEventQueueSystem");
		addMember(l,GenerateEventIdForPayload_s);
		addMember(l,GetGlobalEventQueue_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UnityEventQueueSystem));
	}
}
