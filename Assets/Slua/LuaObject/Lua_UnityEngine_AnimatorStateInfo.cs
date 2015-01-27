using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorStateInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsName(IntPtr l) {
		try{
			UnityEngine.AnimatorStateInfo self=(UnityEngine.AnimatorStateInfo)checkSelf(l);
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
			UnityEngine.AnimatorStateInfo self=(UnityEngine.AnimatorStateInfo)checkSelf(l);
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
		UnityEngine.AnimatorStateInfo o = (UnityEngine.AnimatorStateInfo)checkSelf(l);
		pushValue(l,o.nameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = (UnityEngine.AnimatorStateInfo)checkSelf(l);
		pushValue(l,o.normalizedTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = (UnityEngine.AnimatorStateInfo)checkSelf(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tagHash(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = (UnityEngine.AnimatorStateInfo)checkSelf(l);
		pushValue(l,o.tagHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UnityEngine.AnimatorStateInfo o = (UnityEngine.AnimatorStateInfo)checkSelf(l);
		pushValue(l,o.loop);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorStateInfo");
		addMember(l,IsName);
		addMember(l,IsTag);
		addMember(l,"nameHash",get_nameHash,null,true);
		addMember(l,"normalizedTime",get_normalizedTime,null,true);
		addMember(l,"length",get_length,null,true);
		addMember(l,"tagHash",get_tagHash,null,true);
		addMember(l,"loop",get_loop,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorStateInfo));
	}
}
