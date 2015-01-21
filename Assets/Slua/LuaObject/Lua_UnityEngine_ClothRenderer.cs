using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ClothRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ClothRenderer o;
		if(matchType(l,1)){
			o=new UnityEngine.ClothRenderer();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pauseWhenNotVisible(IntPtr l) {
		UnityEngine.ClothRenderer o = (UnityEngine.ClothRenderer)checkSelf(l);
		pushValue(l,o.pauseWhenNotVisible);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pauseWhenNotVisible(IntPtr l) {
		UnityEngine.ClothRenderer o = (UnityEngine.ClothRenderer)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.pauseWhenNotVisible=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ClothRenderer");
		addMember(l,"pauseWhenNotVisible",get_pauseWhenNotVisible,set_pauseWhenNotVisible);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ClothRenderer),typeof(UnityEngine.Renderer));
	}
}
