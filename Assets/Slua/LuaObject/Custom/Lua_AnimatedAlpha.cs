using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AnimatedAlpha : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		AnimatedAlpha o;
		o=new AnimatedAlpha();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alpha(IntPtr l) {
		AnimatedAlpha o = (AnimatedAlpha)checkSelf(l);
		pushValue(l,o.alpha);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alpha(IntPtr l) {
		AnimatedAlpha o = (AnimatedAlpha)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.alpha=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"AnimatedAlpha");
		addMember(l,"alpha",get_alpha,set_alpha,true);
		createTypeMetatable(l,constructor, typeof(AnimatedAlpha),typeof(UnityEngine.MonoBehaviour));
	}
}
