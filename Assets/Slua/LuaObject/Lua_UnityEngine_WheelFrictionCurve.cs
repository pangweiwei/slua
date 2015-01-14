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
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		pushValue(l,o.extremumSlip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_extremumSlip(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		System.Single v;
		checkType(l,2,out v);
		o.extremumSlip=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_extremumValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		pushValue(l,o.extremumValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_extremumValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		System.Single v;
		checkType(l,2,out v);
		o.extremumValue=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asymptoteSlip(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		pushValue(l,o.asymptoteSlip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_asymptoteSlip(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		System.Single v;
		checkType(l,2,out v);
		o.asymptoteSlip=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asymptoteValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		pushValue(l,o.asymptoteValue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_asymptoteValue(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		System.Single v;
		checkType(l,2,out v);
		o.asymptoteValue=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stiffness(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		pushValue(l,o.stiffness);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stiffness(IntPtr l) {
		UnityEngine.WheelFrictionCurve o = checkSelf<UnityEngine.WheelFrictionCurve>(l);
		System.Single v;
		checkType(l,2,out v);
		o.stiffness=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WheelFrictionCurve");
		addMember(l,get_extremumSlip, "get_extremumSlip");
		addMember(l,set_extremumSlip, "set_extremumSlip");
		addMember(l,get_extremumValue, "get_extremumValue");
		addMember(l,set_extremumValue, "set_extremumValue");
		addMember(l,get_asymptoteSlip, "get_asymptoteSlip");
		addMember(l,set_asymptoteSlip, "set_asymptoteSlip");
		addMember(l,get_asymptoteValue, "get_asymptoteValue");
		addMember(l,set_asymptoteValue, "set_asymptoteValue");
		addMember(l,get_stiffness, "get_stiffness");
		addMember(l,set_stiffness, "set_stiffness");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.WheelFrictionCurve));
		LuaDLL.lua_pop(l, 1);
	}
}
