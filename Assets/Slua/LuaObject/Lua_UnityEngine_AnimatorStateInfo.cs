using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorStateInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsName(IntPtr l) {
		try{
			UnityEngine.AnimatorStateInfo self=checkSelf<UnityEngine.AnimatorStateInfo>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsTag(IntPtr l) {
		try{
			UnityEngine.AnimatorStateInfo self=checkSelf<UnityEngine.AnimatorStateInfo>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsTag(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nameHash(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = checkSelf<UnityEngine.AnimatorStateInfo>(l);
		pushValue(l,o.nameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = checkSelf<UnityEngine.AnimatorStateInfo>(l);
		pushValue(l,o.normalizedTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = checkSelf<UnityEngine.AnimatorStateInfo>(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tagHash(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = checkSelf<UnityEngine.AnimatorStateInfo>(l);
		pushValue(l,o.tagHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = checkSelf<UnityEngine.AnimatorStateInfo>(l);
		pushValue(l,o.loop);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorStateInfo");
		addMember(l,IsName, "IsName");
		addMember(l,IsTag, "IsTag");
		addMember(l,get_nameHash, "get_nameHash");
		addMember(l,get_normalizedTime, "get_normalizedTime");
		addMember(l,get_length, "get_length");
		addMember(l,get_tagHash, "get_tagHash");
		addMember(l,get_loop, "get_loop");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AnimatorStateInfo));
		LuaDLL.lua_pop(l, 1);
	}
}
