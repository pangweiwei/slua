using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationClipPair : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AnimationClipPair o;
		if(matchType(l,1)){
			o=new UnityEngine.AnimationClipPair();
			pushObject(l,o);
			return 1;
		}
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_originalClip(IntPtr l) {
		UnityEngine.AnimationClipPair o = (UnityEngine.AnimationClipPair)checkSelf(l);
		pushValue(l,o.originalClip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_originalClip(IntPtr l) {
		UnityEngine.AnimationClipPair o = (UnityEngine.AnimationClipPair)checkSelf(l);
		UnityEngine.AnimationClip v;
		checkType(l,2,out v);
		o.originalClip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overrideClip(IntPtr l) {
		UnityEngine.AnimationClipPair o = (UnityEngine.AnimationClipPair)checkSelf(l);
		pushValue(l,o.overrideClip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overrideClip(IntPtr l) {
		UnityEngine.AnimationClipPair o = (UnityEngine.AnimationClipPair)checkSelf(l);
		UnityEngine.AnimationClip v;
		checkType(l,2,out v);
		o.overrideClip=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationClipPair");
		addMember(l,"originalClip",get_originalClip,set_originalClip);
		addMember(l,"overrideClip",get_overrideClip,set_overrideClip);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimationClipPair));
	}
}
