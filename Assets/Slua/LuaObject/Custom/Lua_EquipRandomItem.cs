using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_EquipRandomItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		EquipRandomItem o;
		o=new EquipRandomItem();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_equipment(IntPtr l) {
		EquipRandomItem o = (EquipRandomItem)checkSelf(l);
		pushValue(l,o.equipment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_equipment(IntPtr l) {
		EquipRandomItem o = (EquipRandomItem)checkSelf(l);
		InvEquipment v;
		checkType(l,2,out v);
		o.equipment=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"EquipRandomItem");
		addMember(l,"equipment",get_equipment,set_equipment,true);
		createTypeMetatable(l,constructor, typeof(EquipRandomItem),typeof(UnityEngine.MonoBehaviour));
	}
}
