using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightProbeGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.LightProbeGroup o;
		o=new UnityEngine.LightProbeGroup();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_probePositions(IntPtr l) {
		UnityEngine.LightProbeGroup o = (UnityEngine.LightProbeGroup)checkSelf(l);
		pushValue(l,o.probePositions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_probePositions(IntPtr l) {
		UnityEngine.LightProbeGroup o = (UnityEngine.LightProbeGroup)checkSelf(l);
		UnityEngine.Vector3[] v;
		checkType(l,2,out v);
		o.probePositions=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightProbeGroup");
		addMember(l,"probePositions",get_probePositions,set_probePositions,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightProbeGroup),typeof(UnityEngine.Component));
	}
}
