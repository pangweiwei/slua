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
			UnityEngine.LightProbes self=checkSelf<UnityEngine.LightProbes>(l);
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
		UnityEngine.LightProbes o = checkSelf<UnityEngine.LightProbes>(l);
		pushValue(l,o.positions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_coefficients(IntPtr l) {
		UnityEngine.LightProbes o = checkSelf<UnityEngine.LightProbes>(l);
		pushValue(l,o.coefficients);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_coefficients(IntPtr l) {
		UnityEngine.LightProbes o = checkSelf<UnityEngine.LightProbes>(l);
		System.Single[] v;
		checkType(l,2,out v);
		o.coefficients=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_count(IntPtr l) {
		UnityEngine.LightProbes o = checkSelf<UnityEngine.LightProbes>(l);
		pushValue(l,o.count);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cellCount(IntPtr l) {
		UnityEngine.LightProbes o = checkSelf<UnityEngine.LightProbes>(l);
		pushValue(l,o.cellCount);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightProbes");
		addMember(l,GetInterpolatedLightProbe, "GetInterpolatedLightProbe");
		addMember(l,get_positions, "get_positions");
		addMember(l,get_coefficients, "get_coefficients");
		addMember(l,set_coefficients, "set_coefficients");
		addMember(l,get_count, "get_count");
		addMember(l,get_cellCount, "get_cellCount");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.LightProbes),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
