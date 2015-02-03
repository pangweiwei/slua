using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UITable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UITable o;
		o=new UITable();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Reposition(IntPtr l) {
		try{
			UITable self=(UITable)checkSelf(l);
			self.Reposition();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_columns(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		pushValue(l,o.columns);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_columns(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.columns=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		pushEnum(l,(int)o.direction);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		UITable.Direction v;
		checkEnum(l,2,out v);
		o.direction=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sorted(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		pushValue(l,o.sorted);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sorted(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.sorted=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hideInactive(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		pushValue(l,o.hideInactive);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hideInactive(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.hideInactive=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keepWithinPanel(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		pushValue(l,o.keepWithinPanel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keepWithinPanel(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.keepWithinPanel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padding(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		pushValue(l,o.padding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padding(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.padding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onReposition(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		UITable.OnReposition v;
		int op=checkDelegate(l,2,out v);
		if(op==0) o.onReposition=v;
		else if(op==1) o.onReposition+=v;
		else if(op==2) o.onReposition-=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_repositionNow(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		o.repositionNow=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_children(IntPtr l) {
		UITable o = (UITable)checkSelf(l);
		pushValue(l,o.children);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UITable");
		addMember(l,Reposition);
		addMember(l,"columns",get_columns,set_columns,true);
		addMember(l,"direction",get_direction,set_direction,true);
		addMember(l,"sorted",get_sorted,set_sorted,true);
		addMember(l,"hideInactive",get_hideInactive,set_hideInactive,true);
		addMember(l,"keepWithinPanel",get_keepWithinPanel,set_keepWithinPanel,true);
		addMember(l,"padding",get_padding,set_padding,true);
		addMember(l,"onReposition",null,set_onReposition,true);
		addMember(l,"repositionNow",null,set_repositionNow,true);
		addMember(l,"children",get_children,null,true);
		createTypeMetatable(l,constructor, typeof(UITable),typeof(UIWidgetContainer));
	}
}
