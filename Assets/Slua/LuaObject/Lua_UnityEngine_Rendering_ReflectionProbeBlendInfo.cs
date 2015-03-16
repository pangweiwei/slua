using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_probe(IntPtr l) {
		UnityEngine.Rendering.ReflectionProbeBlendInfo o = (UnityEngine.Rendering.ReflectionProbeBlendInfo)checkSelf(l);
		pushValue(l,o.probe);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_probe(IntPtr l) {
		UnityEngine.Rendering.ReflectionProbeBlendInfo o = (UnityEngine.Rendering.ReflectionProbeBlendInfo)checkSelf(l);
		UnityEngine.ReflectionProbe v;
		checkType(l,2,out v);
		o.probe=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight(IntPtr l) {
		UnityEngine.Rendering.ReflectionProbeBlendInfo o = (UnityEngine.Rendering.ReflectionProbeBlendInfo)checkSelf(l);
		pushValue(l,o.weight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight(IntPtr l) {
		UnityEngine.Rendering.ReflectionProbeBlendInfo o = (UnityEngine.Rendering.ReflectionProbeBlendInfo)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.weight=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.ReflectionProbeBlendInfo");
		addMember(l,"probe",get_probe,set_probe,true);
		addMember(l,"weight",get_weight,set_weight,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo));
	}
}
