using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragDropRoot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDragDropRoot o;
		o=new UIDragDropRoot();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_root(IntPtr l) {
		pushValue(l,UIDragDropRoot.root);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_root(IntPtr l) {
		UnityEngine.Transform v;
		checkType(l,2,out v);
		UIDragDropRoot.root=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragDropRoot");
		addMember(l,"root",get_root,set_root,false);
		createTypeMetatable(l,constructor, typeof(UIDragDropRoot),typeof(UnityEngine.MonoBehaviour));
	}
}
