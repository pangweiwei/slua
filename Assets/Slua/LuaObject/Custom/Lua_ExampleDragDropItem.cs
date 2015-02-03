using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_ExampleDragDropItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		ExampleDragDropItem o;
		o=new ExampleDragDropItem();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_prefab(IntPtr l) {
		ExampleDragDropItem o = (ExampleDragDropItem)checkSelf(l);
		pushValue(l,o.prefab);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_prefab(IntPtr l) {
		ExampleDragDropItem o = (ExampleDragDropItem)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.prefab=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"ExampleDragDropItem");
		addMember(l,"prefab",get_prefab,set_prefab,true);
		createTypeMetatable(l,constructor, typeof(ExampleDragDropItem),typeof(UIDragDropItem));
	}
}
