using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Events_UnityEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Events.UnityEvent o;
		o=new UnityEngine.Events.UnityEvent();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddListener(IntPtr l) {
		try{
			UnityEngine.Events.UnityEvent self=(UnityEngine.Events.UnityEvent)checkSelf(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.AddListener(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveListener(IntPtr l) {
		try{
			UnityEngine.Events.UnityEvent self=(UnityEngine.Events.UnityEvent)checkSelf(l);
			UnityEngine.Events.UnityAction a1;
			checkDelegate(l,2,out a1);
			self.RemoveListener(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Invoke(IntPtr l) {
		try{
			UnityEngine.Events.UnityEvent self=(UnityEngine.Events.UnityEvent)checkSelf(l);
			self.Invoke();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Events.UnityEvent");
		addMember(l,AddListener);
		addMember(l,RemoveListener);
		addMember(l,Invoke);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Events.UnityEvent),typeof(UnityEngine.Events.UnityEventBase));
	}
}
