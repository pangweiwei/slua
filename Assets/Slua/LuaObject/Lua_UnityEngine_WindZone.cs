using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WindZone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.WindZone o;
		o=new UnityEngine.WindZone();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		pushEnum(l,(int)o.mode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		UnityEngine.WindZoneMode v;
		checkEnum(l,2,out v);
		o.mode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		pushValue(l,o.radius);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.radius=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_windMain(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		pushValue(l,o.windMain);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_windMain(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.windMain=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_windTurbulence(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		pushValue(l,o.windTurbulence);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_windTurbulence(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.windTurbulence=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_windPulseMagnitude(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		pushValue(l,o.windPulseMagnitude);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_windPulseMagnitude(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.windPulseMagnitude=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_windPulseFrequency(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		pushValue(l,o.windPulseFrequency);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_windPulseFrequency(IntPtr l) {
		UnityEngine.WindZone o = (UnityEngine.WindZone)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.windPulseFrequency=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WindZone");
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"windMain",get_windMain,set_windMain,true);
		addMember(l,"windTurbulence",get_windTurbulence,set_windTurbulence,true);
		addMember(l,"windPulseMagnitude",get_windPulseMagnitude,set_windPulseMagnitude,true);
		addMember(l,"windPulseFrequency",get_windPulseFrequency,set_windPulseFrequency,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WindZone),typeof(UnityEngine.Component));
	}
}
