using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PanWithMouse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		PanWithMouse o;
		o=new PanWithMouse();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_degrees(IntPtr l) {
		PanWithMouse o = (PanWithMouse)checkSelf(l);
		pushValue(l,o.degrees);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_degrees(IntPtr l) {
		PanWithMouse o = (PanWithMouse)checkSelf(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.degrees=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_range(IntPtr l) {
		PanWithMouse o = (PanWithMouse)checkSelf(l);
		pushValue(l,o.range);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_range(IntPtr l) {
		PanWithMouse o = (PanWithMouse)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.range=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"PanWithMouse");
		addMember(l,"degrees",get_degrees,set_degrees,true);
		addMember(l,"range",get_range,set_range,true);
		createTypeMetatable(l,constructor, typeof(PanWithMouse),typeof(UnityEngine.MonoBehaviour));
	}
}
