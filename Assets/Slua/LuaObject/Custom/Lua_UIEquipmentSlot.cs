using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIEquipmentSlot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIEquipmentSlot o;
		o=new UIEquipmentSlot();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_equipment(IntPtr l) {
		UIEquipmentSlot o = (UIEquipmentSlot)checkSelf(l);
		pushValue(l,o.equipment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_equipment(IntPtr l) {
		UIEquipmentSlot o = (UIEquipmentSlot)checkSelf(l);
		InvEquipment v;
		checkType(l,2,out v);
		o.equipment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slot(IntPtr l) {
		UIEquipmentSlot o = (UIEquipmentSlot)checkSelf(l);
		pushEnum(l,(int)o.slot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_slot(IntPtr l) {
		UIEquipmentSlot o = (UIEquipmentSlot)checkSelf(l);
		InvBaseItem.Slot v;
		checkEnum(l,2,out v);
		o.slot=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIEquipmentSlot");
		addMember(l,"equipment",get_equipment,set_equipment,true);
		addMember(l,"slot",get_slot,set_slot,true);
		createTypeMetatable(l,constructor, typeof(UIEquipmentSlot),typeof(UIItemSlot));
	}
}
