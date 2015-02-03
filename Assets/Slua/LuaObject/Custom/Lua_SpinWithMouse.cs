using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_SpinWithMouse : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		SpinWithMouse o;
		o=new SpinWithMouse();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target(IntPtr l) {
		SpinWithMouse o = (SpinWithMouse)checkSelf(l);
		pushValue(l,o.target);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target(IntPtr l) {
		SpinWithMouse o = (SpinWithMouse)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.target=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		SpinWithMouse o = (SpinWithMouse)checkSelf(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		SpinWithMouse o = (SpinWithMouse)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"SpinWithMouse");
		addMember(l,"target",get_target,set_target,true);
		addMember(l,"speed",get_speed,set_speed,true);
		createTypeMetatable(l,constructor, typeof(SpinWithMouse),typeof(UnityEngine.MonoBehaviour));
	}
}
