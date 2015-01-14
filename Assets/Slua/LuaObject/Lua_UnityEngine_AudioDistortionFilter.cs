using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioDistortionFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioDistortionFilter o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioDistortionFilter();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distortionLevel(IntPtr l) {
		UnityEngine.AudioDistortionFilter o = checkSelf<UnityEngine.AudioDistortionFilter>(l);
		pushValue(l,o.distortionLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distortionLevel(IntPtr l) {
		UnityEngine.AudioDistortionFilter o = checkSelf<UnityEngine.AudioDistortionFilter>(l);
		System.Single v;
		checkType(l,2,out v);
		o.distortionLevel=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioDistortionFilter");
		addMember(l,get_distortionLevel, "get_distortionLevel");
		addMember(l,set_distortionLevel, "set_distortionLevel");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioDistortionFilter),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
