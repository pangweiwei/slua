using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvEquipment : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		InvEquipment o;
		o=new InvEquipment();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Replace(IntPtr l) {
		try{
			InvEquipment self=(InvEquipment)checkSelf(l);
			InvBaseItem.Slot a1;
			checkEnum(l,2,out a1);
			InvGameItem a2;
			checkType(l,3,out a2);
			InvGameItem ret=self.Replace(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Equip(IntPtr l) {
		try{
			InvEquipment self=(InvEquipment)checkSelf(l);
			InvGameItem a1;
			checkType(l,2,out a1);
			InvGameItem ret=self.Equip(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Unequip(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(InvGameItem))){
				InvEquipment self=(InvEquipment)checkSelf(l);
				InvGameItem a1;
				checkType(l,2,out a1);
				InvGameItem ret=self.Unequip(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(InvBaseItem.Slot))){
				InvEquipment self=(InvEquipment)checkSelf(l);
				InvBaseItem.Slot a1;
				checkEnum(l,2,out a1);
				InvGameItem ret=self.Unequip(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasEquipped(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(InvGameItem))){
				InvEquipment self=(InvEquipment)checkSelf(l);
				InvGameItem a1;
				checkType(l,2,out a1);
				System.Boolean ret=self.HasEquipped(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(InvBaseItem.Slot))){
				InvEquipment self=(InvEquipment)checkSelf(l);
				InvBaseItem.Slot a1;
				checkEnum(l,2,out a1);
				System.Boolean ret=self.HasEquipped(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItem(IntPtr l) {
		try{
			InvEquipment self=(InvEquipment)checkSelf(l);
			InvBaseItem.Slot a1;
			checkEnum(l,2,out a1);
			InvGameItem ret=self.GetItem(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_equippedItems(IntPtr l) {
		InvEquipment o = (InvEquipment)checkSelf(l);
		pushValue(l,o.equippedItems);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"InvEquipment");
		addMember(l,Replace);
		addMember(l,Equip);
		addMember(l,Unequip);
		addMember(l,HasEquipped);
		addMember(l,GetItem);
		addMember(l,"equippedItems",get_equippedItems,null,true);
		createTypeMetatable(l,constructor, typeof(InvEquipment),typeof(UnityEngine.MonoBehaviour));
	}
}
