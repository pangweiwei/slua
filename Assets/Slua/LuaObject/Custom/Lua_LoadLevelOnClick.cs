using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LoadLevelOnClick : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LoadLevelOnClick o;
		o=new LoadLevelOnClick();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_levelName(IntPtr l) {
		LoadLevelOnClick o = (LoadLevelOnClick)checkSelf(l);
		pushValue(l,o.levelName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_levelName(IntPtr l) {
		LoadLevelOnClick o = (LoadLevelOnClick)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.levelName=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LoadLevelOnClick");
		addMember(l,"levelName",get_levelName,set_levelName,true);
		createTypeMetatable(l,constructor, typeof(LoadLevelOnClick),typeof(UnityEngine.MonoBehaviour));
	}
}
