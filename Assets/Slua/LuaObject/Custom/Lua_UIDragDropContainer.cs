using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragDropContainer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDragDropContainer o;
		o=new UIDragDropContainer();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reparentTarget(IntPtr l) {
		UIDragDropContainer o = (UIDragDropContainer)checkSelf(l);
		pushValue(l,o.reparentTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reparentTarget(IntPtr l) {
		UIDragDropContainer o = (UIDragDropContainer)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.reparentTarget=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragDropContainer");
		addMember(l,"reparentTarget",get_reparentTarget,set_reparentTarget,true);
		createTypeMetatable(l,constructor, typeof(UIDragDropContainer),typeof(UnityEngine.MonoBehaviour));
	}
}
