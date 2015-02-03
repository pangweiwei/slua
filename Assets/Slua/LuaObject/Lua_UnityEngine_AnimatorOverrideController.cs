using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorOverrideController : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AnimatorOverrideController o;
		o=new UnityEngine.AnimatorOverrideController();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runtimeAnimatorController(IntPtr l) {
		UnityEngine.AnimatorOverrideController o = (UnityEngine.AnimatorOverrideController)checkSelf(l);
		pushValue(l,o.runtimeAnimatorController);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runtimeAnimatorController(IntPtr l) {
		UnityEngine.AnimatorOverrideController o = (UnityEngine.AnimatorOverrideController)checkSelf(l);
		UnityEngine.RuntimeAnimatorController v;
		checkType(l,2,out v);
		o.runtimeAnimatorController=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clips(IntPtr l) {
		UnityEngine.AnimatorOverrideController o = (UnityEngine.AnimatorOverrideController)checkSelf(l);
		pushValue(l,o.clips);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clips(IntPtr l) {
		UnityEngine.AnimatorOverrideController o = (UnityEngine.AnimatorOverrideController)checkSelf(l);
		UnityEngine.AnimationClipPair[] v;
		checkType(l,2,out v);
		o.clips=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorOverrideController");
		addMember(l,"runtimeAnimatorController",get_runtimeAnimatorController,set_runtimeAnimatorController,true);
		addMember(l,"clips",get_clips,set_clips,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorOverrideController),typeof(UnityEngine.RuntimeAnimatorController));
	}
}
