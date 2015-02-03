using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUIText_GlyphInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		NGUIText.GlyphInfo o;
		o=new NGUIText.GlyphInfo();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_v0(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.v0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_v0(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.v0=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_v1(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.v1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_v1(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.v1=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u0(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.u0);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u0(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.u0=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u1(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.u1);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u1(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.u1=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u2(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.u2);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u2(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.u2=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_u3(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.u3);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_u3(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.u3=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_advance(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.advance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_advance(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.advance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_channel(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		pushValue(l,o.channel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_channel(IntPtr l) {
		NGUIText.GlyphInfo o = (NGUIText.GlyphInfo)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.channel=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NGUIText.GlyphInfo");
		addMember(l,"v0",get_v0,set_v0,true);
		addMember(l,"v1",get_v1,set_v1,true);
		addMember(l,"u0",get_u0,set_u0,true);
		addMember(l,"u1",get_u1,set_u1,true);
		addMember(l,"u2",get_u2,set_u2,true);
		addMember(l,"u3",get_u3,set_u3,true);
		addMember(l,"advance",get_advance,set_advance,true);
		addMember(l,"channel",get_channel,set_channel,true);
		createTypeMetatable(l,constructor, typeof(NGUIText.GlyphInfo));
	}
}
