using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AsyncOperation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AsyncOperation o;
		o=new UnityEngine.AsyncOperation();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDone(IntPtr l) {
		UnityEngine.AsyncOperation o = (UnityEngine.AsyncOperation)checkSelf(l);
		pushValue(l,o.isDone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_progress(IntPtr l) {
		UnityEngine.AsyncOperation o = (UnityEngine.AsyncOperation)checkSelf(l);
		pushValue(l,o.progress);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_priority(IntPtr l) {
		UnityEngine.AsyncOperation o = (UnityEngine.AsyncOperation)checkSelf(l);
		pushValue(l,o.priority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_priority(IntPtr l) {
		UnityEngine.AsyncOperation o = (UnityEngine.AsyncOperation)checkSelf(l);
		int v;
		checkType(l,2,out v);
		o.priority=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_allowSceneActivation(IntPtr l) {
		UnityEngine.AsyncOperation o = (UnityEngine.AsyncOperation)checkSelf(l);
		pushValue(l,o.allowSceneActivation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_allowSceneActivation(IntPtr l) {
		UnityEngine.AsyncOperation o = (UnityEngine.AsyncOperation)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.allowSceneActivation=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AsyncOperation");
		addMember(l,"isDone",get_isDone,null,true);
		addMember(l,"progress",get_progress,null,true);
		addMember(l,"priority",get_priority,set_priority,true);
		addMember(l,"allowSceneActivation",get_allowSceneActivation,set_allowSceneActivation,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AsyncOperation),typeof(UnityEngine.YieldInstruction));
	}
}
