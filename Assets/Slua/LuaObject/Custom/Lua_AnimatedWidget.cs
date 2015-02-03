using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_AnimatedWidget : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		AnimatedWidget o;
		o=new AnimatedWidget();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		AnimatedWidget o = (AnimatedWidget)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		AnimatedWidget o = (AnimatedWidget)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		AnimatedWidget o = (AnimatedWidget)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		AnimatedWidget o = (AnimatedWidget)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"AnimatedWidget");
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		createTypeMetatable(l,constructor, typeof(AnimatedWidget),typeof(UnityEngine.MonoBehaviour));
	}
}
