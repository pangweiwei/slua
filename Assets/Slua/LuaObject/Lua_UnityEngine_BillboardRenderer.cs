using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BillboardRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.BillboardRenderer o;
		o=new UnityEngine.BillboardRenderer();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_billboard(IntPtr l) {
		UnityEngine.BillboardRenderer o = (UnityEngine.BillboardRenderer)checkSelf(l);
		pushValue(l,o.billboard);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_billboard(IntPtr l) {
		UnityEngine.BillboardRenderer o = (UnityEngine.BillboardRenderer)checkSelf(l);
		UnityEngine.BillboardAsset v;
		checkType(l,2,out v);
		o.billboard=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BillboardRenderer");
		addMember(l,"billboard",get_billboard,set_billboard,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.BillboardRenderer),typeof(UnityEngine.Renderer));
	}
}
