using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_BMGlyph : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		BMGlyph o;
		o=new BMGlyph();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKerning(IntPtr l) {
		try{
			BMGlyph self=(BMGlyph)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 ret=self.GetKerning(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetKerning(IntPtr l) {
		try{
			BMGlyph self=(BMGlyph)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetKerning(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Trim(IntPtr l) {
		try{
			BMGlyph self=(BMGlyph)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.Trim(a1,a2,a3,a4);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_index(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.index);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_index(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.index=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_x(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.x);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_x(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.x=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_y(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.y);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_y(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.y=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.width=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_height(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.height);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.height=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetX(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.offsetX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetX(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.offsetX=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offsetY(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.offsetY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_offsetY(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.offsetY=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_advance(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.advance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_advance(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.advance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_channel(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.channel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_channel(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.channel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kerning(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		pushValue(l,o.kerning);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_kerning(IntPtr l) {
		BMGlyph o = (BMGlyph)checkSelf(l);
		System.Collections.Generic.List<System.Int32> v;
		checkType(l,2,out v);
		o.kerning=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"BMGlyph");
		addMember(l,GetKerning);
		addMember(l,SetKerning);
		addMember(l,Trim);
		addMember(l,"index",get_index,set_index,true);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"offsetX",get_offsetX,set_offsetX,true);
		addMember(l,"offsetY",get_offsetY,set_offsetY,true);
		addMember(l,"advance",get_advance,set_advance,true);
		addMember(l,"channel",get_channel,set_channel,true);
		addMember(l,"kerning",get_kerning,set_kerning,true);
		createTypeMetatable(l,constructor, typeof(BMGlyph));
	}
}
