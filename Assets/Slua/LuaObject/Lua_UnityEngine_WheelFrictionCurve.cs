using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WheelFrictionCurve : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_extremumSlip(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		pushValue(l,o.extremumSlip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_extremumSlip(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.extremumSlip=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_extremumValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		pushValue(l,o.extremumValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_extremumValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.extremumValue=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asymptoteSlip(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		pushValue(l,o.asymptoteSlip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_asymptoteSlip(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.asymptoteSlip=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asymptoteValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		pushValue(l,o.asymptoteValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_asymptoteValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.asymptoteValue=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stiffness(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		pushValue(l,o.stiffness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stiffness(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = (UnityEngine.WheelFrictionCurve)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.stiffness=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WheelFrictionCurve");
		addMember(l,"extremumSlip",get_extremumSlip,set_extremumSlip);
		addMember(l,"extremumValue",get_extremumValue,set_extremumValue);
		addMember(l,"asymptoteSlip",get_asymptoteSlip,set_asymptoteSlip);
		addMember(l,"asymptoteValue",get_asymptoteValue,set_asymptoteValue);
		addMember(l,"stiffness",get_stiffness,set_stiffness);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WheelFrictionCurve));
	}
}
