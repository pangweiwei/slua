using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CharacterInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
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
		pushEnum(l,(int)o.style);
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
	static public int get_advance(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.advance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_glyphWidth(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.glyphWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_glyphHeight(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.glyphHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bearing(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.bearing);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minY(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.minY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxY(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.maxY);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minX(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.minX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxX(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.maxX);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvBottomLeft(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.uvBottomLeft);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvBottomRight(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.uvBottomRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvTopRight(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.uvTopRight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvTopLeft(IntPtr l) {
		UnityEngine.CharacterInfo o = (UnityEngine.CharacterInfo)checkSelf(l);
		pushValue(l,o.uvTopLeft);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CharacterInfo");
		addMember(l,"index",get_index,set_index,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"style",get_style,set_style,true);
		addMember(l,"advance",get_advance,null,true);
		addMember(l,"glyphWidth",get_glyphWidth,null,true);
		addMember(l,"glyphHeight",get_glyphHeight,null,true);
		addMember(l,"bearing",get_bearing,null,true);
		addMember(l,"minY",get_minY,null,true);
		addMember(l,"maxY",get_maxY,null,true);
		addMember(l,"minX",get_minX,null,true);
		addMember(l,"maxX",get_maxX,null,true);
		addMember(l,"uvBottomLeft",get_uvBottomLeft,null,true);
		addMember(l,"uvBottomRight",get_uvBottomRight,null,true);
		addMember(l,"uvTopRight",get_uvTopRight,null,true);
		addMember(l,"uvTopLeft",get_uvTopLeft,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CharacterInfo));
	}
}
