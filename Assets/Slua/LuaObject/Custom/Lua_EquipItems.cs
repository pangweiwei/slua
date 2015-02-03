using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EquipItems : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		EquipItems o;
		o=new EquipItems();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_itemIDs(IntPtr l) {
		EquipItems o = (EquipItems)checkSelf(l);
		pushValue(l,o.itemIDs);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_itemIDs(IntPtr l) {
		EquipItems o = (EquipItems)checkSelf(l);
		System.Int32[] v;
		checkType(l,2,out v);
		o.itemIDs=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EquipItems");
		addMember(l,"itemIDs",get_itemIDs,set_itemIDs,true);
		createTypeMetatable(l,constructor, typeof(EquipItems),typeof(UnityEngine.MonoBehaviour));
	}
}
