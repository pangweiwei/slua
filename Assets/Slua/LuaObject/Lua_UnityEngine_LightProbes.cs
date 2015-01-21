using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightProbes : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.LightProbes o;
		if(matchType(l,1)){
			o=new UnityEngine.LightProbes();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInterpolatedLightProbe(IntPtr l) {
		try{
			UnityEngine.LightProbes self=(UnityEngine.LightProbes)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Renderer a2;
			checkType(l,3,out a2);
			System.Single[] a3;
			checkType(l,4,out a3);
			self.GetInterpolatedLightProbe(a1,a2,a3);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positions(IntPtr l) {
		UnityEngine.LightProbes o = (UnityEngine.LightProbes)checkSelf(l);
		pushValue(l,o.positions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_coefficients(IntPtr l) {
		UnityEngine.LightProbes o = (UnityEngine.LightProbes)checkSelf(l);
		pushValue(l,o.coefficients);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_coefficients(IntPtr l) {
		UnityEngine.LightProbes o = (UnityEngine.LightProbes)checkSelf(l);
		float[] v;
		checkType(l,2,out v);
		o.coefficients=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_count(IntPtr l) {
		UnityEngine.LightProbes o = (UnityEngine.LightProbes)checkSelf(l);
		pushValue(l,o.count);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cellCount(IntPtr l) {
		UnityEngine.LightProbes o = (UnityEngine.LightProbes)checkSelf(l);
		pushValue(l,o.cellCount);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightProbes");
		addMember(l,GetInterpolatedLightProbe);
		addMember(l,"positions",get_positions,null);
		addMember(l,"coefficients",get_coefficients,set_coefficients);
		addMember(l,"count",get_count,null);
		addMember(l,"cellCount",get_cellCount,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightProbes),typeof(UnityEngine.Object));
	}
}
