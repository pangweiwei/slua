using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AssetBundleCreateRequest : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AssetBundleCreateRequest o;
		o=new UnityEngine.AssetBundleCreateRequest();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_assetBundle(IntPtr l) {
		UnityEngine.AssetBundleCreateRequest o = (UnityEngine.AssetBundleCreateRequest)checkSelf(l);
		pushValue(l,o.assetBundle);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundleCreateRequest");
		addMember(l,"assetBundle",get_assetBundle,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundleCreateRequest),typeof(UnityEngine.AsyncOperation));
	}
}
