using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SkinnedCloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.SkinnedCloth o;
		o=new UnityEngine.SkinnedCloth();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetEnabledFading(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetEnabledFading(a1,a2);
				return 0;
			}
			else if(argc==1){
				UnityEngine.SkinnedCloth self=(UnityEngine.SkinnedCloth)checkSelf(l);
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
		UnityEngine.SkinnedCloth o = (UnityEngine.SkinnedCloth)checkSelf(l);
		pushValue(l,o.coefficients);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_coefficients(IntPtr l) {
		UnityEngine.SkinnedCloth o = (UnityEngine.SkinnedCloth)checkSelf(l);
		UnityEngine.ClothSkinningCoefficient[] v;
		checkType(l,2,out v);
		o.coefficients=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldVelocityScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = (UnityEngine.SkinnedCloth)checkSelf(l);
		pushValue(l,o.worldVelocityScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldVelocityScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = (UnityEngine.SkinnedCloth)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.worldVelocityScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldAccelerationScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = (UnityEngine.SkinnedCloth)checkSelf(l);
		pushValue(l,o.worldAccelerationScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldAccelerationScale(IntPtr l) {
		UnityEngine.SkinnedCloth o = (UnityEngine.SkinnedCloth)checkSelf(l);
		float v;
		checkType(l,2,out v);
		o.worldAccelerationScale=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SkinnedCloth");
		addMember(l,SetEnabledFading);
		addMember(l,"coefficients",get_coefficients,set_coefficients,true);
		addMember(l,"worldVelocityScale",get_worldVelocityScale,set_worldVelocityScale,true);
		addMember(l,"worldAccelerationScale",get_worldAccelerationScale,set_worldAccelerationScale,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SkinnedCloth),typeof(UnityEngine.Cloth));
	}
}
