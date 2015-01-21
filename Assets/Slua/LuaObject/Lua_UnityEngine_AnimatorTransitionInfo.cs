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
			UnityEngine.AnimatorTransitionInfo self=(UnityEngine.AnimatorTransitionInfo)checkSelf(l);
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
			UnityEngine.AnimatorTransitionInfo self=(UnityEngine.AnimatorTransitionInfo)checkSelf(l);
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
		UnityEngine.AnimatorTransitionInfo o = (UnityEngine.AnimatorTransitionInfo)checkSelf(l);
		pushValue(l,o.nameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_userNameHash(IntPtr l) {
		UnityEngine.AnimatorTransitionInfo o = (UnityEngine.AnimatorTransitionInfo)checkSelf(l);
		pushValue(l,o.userNameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		UnityEngine.AnimatorTransitionInfo o = (UnityEngine.AnimatorTransitionInfo)checkSelf(l);
		pushValue(l,o.normalizedTime);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorTransitionInfo");
		addMember(l,IsName);
		addMember(l,IsUserName);
		addMember(l,"nameHash",get_nameHash,null);
		addMember(l,"userNameHash",get_userNameHash,null);
		addMember(l,"normalizedTime",get_normalizedTime,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorTransitionInfo));
	}
}
