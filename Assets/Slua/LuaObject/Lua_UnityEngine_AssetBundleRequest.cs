using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AssetBundleRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AssetBundleRequest o;
		o=new UnityEngine.AssetBundleRequest();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asset(IntPtr l) {
		UnityEngine.AssetBundleRequest o = (UnityEngine.AssetBundleRequest)checkSelf(l);
		pushValue(l,o.asset);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundleRequest");
		addMember(l,"asset",get_asset,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundleRequest),typeof(UnityEngine.AsyncOperation));
	}
}
