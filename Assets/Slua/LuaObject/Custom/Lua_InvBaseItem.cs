using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvBaseItem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		InvBaseItem o;
		o=new InvBaseItem();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_id16(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.id16);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_id16(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.id16=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_description(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.description);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_description(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.description=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_slot(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushEnum(l,(int)o.slot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_slot(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		InvBaseItem.Slot v;
		checkEnum(l,2,out v);
		o.slot=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minItemLevel(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.minItemLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minItemLevel(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.minItemLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxItemLevel(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.maxItemLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxItemLevel(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxItemLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stats(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.stats);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stats(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		System.Collections.Generic.List<InvStat> v;
		checkType(l,2,out v);
		o.stats=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_attachment(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.attachment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_attachment(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.attachment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_iconAtlas(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.iconAtlas);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_iconAtlas(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		UIAtlas v;
		checkType(l,2,out v);
		o.iconAtlas=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_iconName(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		pushValue(l,o.iconName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_iconName(IntPtr l) {
		InvBaseItem o = (InvBaseItem)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.iconName=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"InvBaseItem");
		addMember(l,"id16",get_id16,set_id16,true);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"description",get_description,set_description,true);
		addMember(l,"slot",get_slot,set_slot,true);
		addMember(l,"minItemLevel",get_minItemLevel,set_minItemLevel,true);
		addMember(l,"maxItemLevel",get_maxItemLevel,set_maxItemLevel,true);
		addMember(l,"stats",get_stats,set_stats,true);
		addMember(l,"attachment",get_attachment,set_attachment,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"iconAtlas",get_iconAtlas,set_iconAtlas,true);
		addMember(l,"iconName",get_iconName,set_iconName,true);
		createTypeMetatable(l,constructor, typeof(InvBaseItem));
	}
}
