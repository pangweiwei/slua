using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragScrollView : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDragScrollView o;
		o=new UIDragScrollView();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scrollView(IntPtr l) {
		UIDragScrollView o = (UIDragScrollView)checkSelf(l);
		pushValue(l,o.scrollView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scrollView(IntPtr l) {
		UIDragScrollView o = (UIDragScrollView)checkSelf(l);
		UIScrollView v;
		checkType(l,2,out v);
		o.scrollView=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragScrollView");
		addMember(l,"scrollView",get_scrollView,set_scrollView,true);
		createTypeMetatable(l,constructor, typeof(UIDragScrollView),typeof(UnityEngine.MonoBehaviour));
	}
}
