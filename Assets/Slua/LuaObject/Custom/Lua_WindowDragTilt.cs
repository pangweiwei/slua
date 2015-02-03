using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_WindowDragTilt : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		WindowDragTilt o;
		o=new WindowDragTilt();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateOrder(IntPtr l) {
		WindowDragTilt o = (WindowDragTilt)checkSelf(l);
		pushValue(l,o.updateOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateOrder(IntPtr l) {
		WindowDragTilt o = (WindowDragTilt)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.updateOrder=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_degrees(IntPtr l) {
		WindowDragTilt o = (WindowDragTilt)checkSelf(l);
		pushValue(l,o.degrees);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_degrees(IntPtr l) {
		WindowDragTilt o = (WindowDragTilt)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.degrees=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"WindowDragTilt");
		addMember(l,"updateOrder",get_updateOrder,set_updateOrder,true);
		addMember(l,"degrees",get_degrees,set_degrees,true);
		createTypeMetatable(l,constructor, typeof(WindowDragTilt),typeof(UnityEngine.MonoBehaviour));
	}
}
