using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightProbes : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.LightProbes o;
		o=new UnityEngine.LightProbes();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInterpolatedProbe_s(IntPtr l) {
		try{
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Renderer a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.SphericalHarmonicsL2 a3;
			UnityEngine.LightProbes.GetInterpolatedProbe(a1,a2,out a3);
			pushValue(l,a3);
			return 1;
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
	static public int get_bakedProbes(IntPtr l) {
		UnityEngine.LightProbes o = (UnityEngine.LightProbes)checkSelf(l);
		pushValue(l,o.bakedProbes);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bakedProbes(IntPtr l) {
		UnityEngine.LightProbes o = (UnityEngine.LightProbes)checkSelf(l);
		UnityEngine.Rendering.SphericalHarmonicsL2[] v;
		checkType(l,2,out v);
		o.bakedProbes=v;
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
		addMember(l,GetInterpolatedProbe_s);
		addMember(l,"positions",get_positions,null,true);
		addMember(l,"bakedProbes",get_bakedProbes,set_bakedProbes,true);
		addMember(l,"count",get_count,null,true);
		addMember(l,"cellCount",get_cellCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightProbes),typeof(UnityEngine.Object));
	}
}
