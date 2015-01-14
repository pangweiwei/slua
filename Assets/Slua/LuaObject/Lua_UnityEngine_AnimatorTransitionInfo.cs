using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorTransitionInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsName(IntPtr l) {
		try{
			UnityEngine.AnimatorTransitionInfo self=checkSelf<UnityEngine.AnimatorTransitionInfo>(l);
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
	static public int IsUserName(IntPtr l) {
		try{
			UnityEngine.AnimatorTransitionInfo self=checkSelf<UnityEngine.AnimatorTransitionInfo>(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.IsUserName(a1);
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
		UnityEngine.AnimatorTransitionInfo o = checkSelf<UnityEngine.AnimatorTransitionInfo>(l);
		pushValue(l,o.nameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_userNameHash(IntPtr l) {
		UnityEngine.AnimatorTransitionInfo o = checkSelf<UnityEngine.AnimatorTransitionInfo>(l);
		pushValue(l,o.userNameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		UnityEngine.AnimatorTransitionInfo o = checkSelf<UnityEngine.AnimatorTransitionInfo>(l);
		pushValue(l,o.normalizedTime);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorTransitionInfo");
		addMember(l,IsName, "IsName");
		addMember(l,IsUserName, "IsUserName");
		addMember(l,get_nameHash, "get_nameHash");
		addMember(l,get_userNameHash, "get_userNameHash");
		addMember(l,get_normalizedTime, "get_normalizedTime");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AnimatorTransitionInfo));
		LuaDLL.lua_pop(l, 1);
	}
}
