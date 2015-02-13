using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ResourceRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.ResourceRequest o;
		o=new UnityEngine.ResourceRequest();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asset(IntPtr l) {
		UnityEngine.ResourceRequest o = (UnityEngine.ResourceRequest)checkSelf(l);
		pushValue(l,o.asset);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ResourceRequest");
		addMember(l,"asset",get_asset,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ResourceRequest),typeof(UnityEngine.AsyncOperation));
	}
}
