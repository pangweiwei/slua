using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIDragDropItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIDragDropItem o;
		o=new UIDragDropItem();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_restriction(IntPtr l) {
		UIDragDropItem o = (UIDragDropItem)checkSelf(l);
		pushEnum(l,(int)o.restriction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_restriction(IntPtr l) {
		UIDragDropItem o = (UIDragDropItem)checkSelf(l);
		UIDragDropItem.Restriction v;
		checkEnum(l,2,out v);
		o.restriction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cloneOnDrag(IntPtr l) {
		UIDragDropItem o = (UIDragDropItem)checkSelf(l);
		pushValue(l,o.cloneOnDrag);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cloneOnDrag(IntPtr l) {
		UIDragDropItem o = (UIDragDropItem)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.cloneOnDrag=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIDragDropItem");
		addMember(l,"restriction",get_restriction,set_restriction,true);
		addMember(l,"cloneOnDrag",get_cloneOnDrag,set_cloneOnDrag,true);
		createTypeMetatable(l,constructor, typeof(UIDragDropItem),typeof(UnityEngine.MonoBehaviour));
	}
}
