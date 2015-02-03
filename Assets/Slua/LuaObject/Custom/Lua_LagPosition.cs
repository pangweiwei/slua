using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LagPosition : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LagPosition o;
		o=new LagPosition();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateOrder(IntPtr l) {
		LagPosition o = (LagPosition)checkSelf(l);
		pushValue(l,o.updateOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateOrder(IntPtr l) {
		LagPosition o = (LagPosition)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.updateOrder=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		LagPosition o = (LagPosition)checkSelf(l);
		pushValue(l,o.speed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		LagPosition o = (LagPosition)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.speed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreTimeScale(IntPtr l) {
		LagPosition o = (LagPosition)checkSelf(l);
		pushValue(l,o.ignoreTimeScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreTimeScale(IntPtr l) {
		LagPosition o = (LagPosition)checkSelf(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreTimeScale=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LagPosition");
		addMember(l,"updateOrder",get_updateOrder,set_updateOrder,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		createTypeMetatable(l,constructor, typeof(LagPosition),typeof(UnityEngine.MonoBehaviour));
	}
}
