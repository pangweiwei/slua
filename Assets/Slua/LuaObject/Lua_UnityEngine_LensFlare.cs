using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LensFlare : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.LensFlare o;
		o=new UnityEngine.LensFlare();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flare(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		pushValue(l,o.flare);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flare(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		UnityEngine.Flare v;
		checkType(l,2,out v);
		o.flare=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_brightness(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		pushValue(l,o.brightness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_brightness(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.brightness=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fadeSpeed(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		pushValue(l,o.fadeSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fadeSpeed(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.fadeSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.LensFlare o = (UnityEngine.LensFlare)checkSelf(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LensFlare");
		addMember(l,"flare",get_flare,set_flare,true);
		addMember(l,"brightness",get_brightness,set_brightness,true);
		addMember(l,"fadeSpeed",get_fadeSpeed,set_fadeSpeed,true);
		addMember(l,"color",get_color,set_color,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LensFlare),typeof(UnityEngine.Behaviour));
	}
}
