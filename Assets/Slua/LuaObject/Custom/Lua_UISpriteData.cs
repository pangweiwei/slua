using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UISpriteData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UISpriteData o;
		o=new UISpriteData();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRect(IntPtr l) {
		try{
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetRect(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPadding(IntPtr l) {
		try{
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetPadding(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetBorder(IntPtr l) {
		try{
			UISpriteData self=(UISpriteData)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetBorder(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyFrom(IntPtr l) {
		try{
			UISpriteData self=(UISpriteData)checkSelf(l);
			UISpriteData a1;
			checkType(l,2,out a1);
			self.CopyFrom(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyBorderFrom(IntPtr l) {
		try{
			UISpriteData self=(UISpriteData)checkSelf(l);
			UISpriteData a1;
			checkType(l,2,out a1);
			self.CopyBorderFrom(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.name);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.name=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.x=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.y=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderLeft(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.borderLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderLeft(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.borderLeft=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderRight(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.borderRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderRight(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.borderRight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderTop(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.borderTop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderTop(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.borderTop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_borderBottom(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.borderBottom);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_borderBottom(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.borderBottom=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingLeft(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.paddingLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingLeft(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.paddingLeft=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingRight(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.paddingRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingRight(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.paddingRight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingTop(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.paddingTop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingTop(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.paddingTop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_paddingBottom(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.paddingBottom);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_paddingBottom(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.paddingBottom=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBorder(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.hasBorder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasPadding(IntPtr l) {
		UISpriteData o = (UISpriteData)checkSelf(l);
		pushValue(l,o.hasPadding);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UISpriteData");
		addMember(l,SetRect);
		addMember(l,SetPadding);
		addMember(l,SetBorder);
		addMember(l,CopyFrom);
		addMember(l,CopyBorderFrom);
		addMember(l,"name",get_name,set_name,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"borderLeft",get_borderLeft,set_borderLeft,true);
		addMember(l,"borderRight",get_borderRight,set_borderRight,true);
		addMember(l,"borderTop",get_borderTop,set_borderTop,true);
		addMember(l,"borderBottom",get_borderBottom,set_borderBottom,true);
		addMember(l,"paddingLeft",get_paddingLeft,set_paddingLeft,true);
		addMember(l,"paddingRight",get_paddingRight,set_paddingRight,true);
		addMember(l,"paddingTop",get_paddingTop,set_paddingTop,true);
		addMember(l,"paddingBottom",get_paddingBottom,set_paddingBottom,true);
		addMember(l,"hasBorder",get_hasBorder,null,true);
		addMember(l,"hasPadding",get_hasPadding,null,true);
		createTypeMetatable(l,constructor, typeof(UISpriteData));
	}
}
