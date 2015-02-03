using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_DownloadTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		DownloadTexture o;
		o=new DownloadTexture();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_url(IntPtr l) {
		DownloadTexture o = (DownloadTexture)checkSelf(l);
		pushValue(l,o.url);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_url(IntPtr l) {
		DownloadTexture o = (DownloadTexture)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.url=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"DownloadTexture");
		addMember(l,"url",get_url,set_url,true);
		createTypeMetatable(l,constructor, typeof(DownloadTexture),typeof(UnityEngine.MonoBehaviour));
	}
}
