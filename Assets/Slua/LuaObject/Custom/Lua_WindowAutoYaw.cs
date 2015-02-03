using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_WindowAutoYaw : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		WindowAutoYaw o;
		o=new WindowAutoYaw();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateOrder(IntPtr l) {
		WindowAutoYaw o = (WindowAutoYaw)checkSelf(l);
		pushValue(l,o.updateOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateOrder(IntPtr l) {
		WindowAutoYaw o = (WindowAutoYaw)checkSelf(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.updateOrder=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiCamera(IntPtr l) {
		WindowAutoYaw o = (WindowAutoYaw)checkSelf(l);
		pushValue(l,o.uiCamera);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiCamera(IntPtr l) {
		WindowAutoYaw o = (WindowAutoYaw)checkSelf(l);
		UnityEngine.Camera v;
		checkType(l,2,out v);
		o.uiCamera=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yawAmount(IntPtr l) {
		WindowAutoYaw o = (WindowAutoYaw)checkSelf(l);
		pushValue(l,o.yawAmount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_yawAmount(IntPtr l) {
		WindowAutoYaw o = (WindowAutoYaw)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.yawAmount=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"WindowAutoYaw");
		addMember(l,"updateOrder",get_updateOrder,set_updateOrder,true);
		addMember(l,"uiCamera",get_uiCamera,set_uiCamera,true);
		addMember(l,"yawAmount",get_yawAmount,set_yawAmount,true);
		createTypeMetatable(l,constructor, typeof(WindowAutoYaw),typeof(UnityEngine.MonoBehaviour));
	}
}
