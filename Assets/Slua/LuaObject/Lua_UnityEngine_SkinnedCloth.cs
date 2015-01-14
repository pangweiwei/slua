using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SkinnedCloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.SkinnedCloth o;
		if(matchType(l,1)){
			o=new UnityEngine.SkinnedCloth();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEnabledFading(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Boolean),typeof(System.Single))){
				UnityEngine.SkinnedCloth self=checkSelf<UnityEngine.SkinnedCloth>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetEnabledFading(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(System.Boolean))){
				UnityEngine.SkinnedCloth self=checkSelf<UnityEngine.SkinnedCloth>(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.SetEnabledFading(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_coefficients(IntPtr l) {
		UnityEngine.SkinnedCloth o = checkSelf<UnityEngine.SkinnedCloth>(l);
		pushValue(l,o.coefficients);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_coefficients(IntPtr l) {
		UnityEngine.SkinnedCloth o = checkSelf<UnityEngine.SkinnedCloth>(l);
		UnityEngine.ClothSkinningCoefficient[] v;
		checkType(l,2,out v);
		o.coefficients=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldVelocityScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = checkSelf<UnityEngine.SkinnedCloth>(l);
		pushValue(l,o.worldVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldVelocityScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = checkSelf<UnityEngine.SkinnedCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.worldVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldAccelerationScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = checkSelf<UnityEngine.SkinnedCloth>(l);
		pushValue(l,o.worldAccelerationScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldAccelerationScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = checkSelf<UnityEngine.SkinnedCloth>(l);
		System.Single v;
		checkType(l,2,out v);
		o.worldAccelerationScale=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SkinnedCloth");
		addMember(l,SetEnabledFading, "SetEnabledFading");
		addMember(l,get_coefficients, "get_coefficients");
		addMember(l,set_coefficients, "set_coefficients");
		addMember(l,get_worldVelocityScale, "get_worldVelocityScale");
		addMember(l,set_worldVelocityScale, "set_worldVelocityScale");
		addMember(l,get_worldAccelerationScale, "get_worldAccelerationScale");
		addMember(l,set_worldAccelerationScale, "set_worldAccelerationScale");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.SkinnedCloth),typeof(UnityEngine.Cloth));
		LuaDLL.lua_pop(l, 1);
	}
}
