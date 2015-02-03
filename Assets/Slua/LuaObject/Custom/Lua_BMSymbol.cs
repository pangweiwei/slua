using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_BMSymbol : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		BMSymbol o;
		o=new BMSymbol();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkAsChanged(IntPtr l) {
		try{
			BMSymbol self=(BMSymbol)checkSelf(l);
			self.MarkAsChanged();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Validate(IntPtr l) {
		try{
			BMSymbol self=(BMSymbol)checkSelf(l);
			UIAtlas a1;
			checkType(l,2,out a1);
			System.Boolean ret=self.Validate(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sequence(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.sequence);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sequence(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.sequence=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteName(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.spriteName);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteName(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		System.String v;
		checkType(l,2,out v);
		o.spriteName=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetX(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.offsetX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetY(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.offsetY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_advance(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.advance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvRect(IntPtr l) {
		BMSymbol o = (BMSymbol)checkSelf(l);
		pushValue(l,o.uvRect);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"BMSymbol");
		addMember(l,MarkAsChanged);
		addMember(l,Validate);
		addMember(l,"sequence",get_sequence,set_sequence,true);
		addMember(l,"spriteName",get_spriteName,set_spriteName,true);
		addMember(l,"length",get_length,null,true);
		addMember(l,"offsetX",get_offsetX,null,true);
		addMember(l,"offsetY",get_offsetY,null,true);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		addMember(l,"advance",get_advance,null,true);
		addMember(l,"uvRect",get_uvRect,null,true);
		createTypeMetatable(l,constructor, typeof(BMSymbol));
	}
}
