using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIItemStorage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIItemStorage o;
		o=new UIItemStorage();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetItem(IntPtr l) {
		try{
			UIItemStorage self=(UIItemStorage)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
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
	static public int Replace(IntPtr l) {
		try{
			UIItemStorage self=(UIItemStorage)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
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
	static public int get_maxItemCount(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.maxItemCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxItemCount(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxItemCount=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxRows(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.maxRows);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxRows(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxRows=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxColumns(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.maxColumns);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxColumns(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.maxColumns=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_template(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.template);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_template(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		o.template=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_background(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.background);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_background(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		UIWidget v;
		checkType(l,2,out v);
		o.background=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacing(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.spacing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacing(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.spacing=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padding(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.padding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padding(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.padding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_items(IntPtr l) {
		UIItemStorage o = (UIItemStorage)checkSelf(l);
		pushValue(l,o.items);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIItemStorage");
		addMember(l,GetItem);
		addMember(l,Replace);
		addMember(l,"maxItemCount",get_maxItemCount,set_maxItemCount,true);
		addMember(l,"maxRows",get_maxRows,set_maxRows,true);
		addMember(l,"maxColumns",get_maxColumns,set_maxColumns,true);
		addMember(l,"template",get_template,set_template,true);
		addMember(l,"background",get_background,set_background,true);
		addMember(l,"spacing",get_spacing,set_spacing,true);
		addMember(l,"padding",get_padding,set_padding,true);
		addMember(l,"items",get_items,null,true);
		createTypeMetatable(l,constructor, typeof(UIItemStorage),typeof(UnityEngine.MonoBehaviour));
	}
}
