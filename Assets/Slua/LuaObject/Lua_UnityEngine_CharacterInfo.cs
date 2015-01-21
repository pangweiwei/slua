using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CharacterInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_index(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.index);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_index(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.index=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.uv);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		UnityEngine.Rect v;
		checkType(l,2,out v);
		o.uv=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vert(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.vert);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vert(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		UnityEngine.Rect v;
		checkType(l,2,out v);
		o.vert=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_width(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.width);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_width(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.width=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_style(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.style);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_style(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		UnityEngine.FontStyle v;
		checkEnum(l,2,out v);
		o.style=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flipped(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.flipped);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flipped(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.flipped=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterInfo");
		addMember(l,"index",get_index,set_index);
		addMember(l,"uv",get_uv,set_uv);
		addMember(l,"vert",get_vert,set_vert);
		addMember(l,"width",get_width,set_width);
		addMember(l,"size",get_size,set_size);
		addMember(l,"style",get_style,set_style);
		addMember(l,"flipped",get_flipped,set_flipped);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CharacterInfo));
	}
}
