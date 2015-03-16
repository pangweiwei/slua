using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_SphericalHarmonicsL2 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.luaL_error(l,"New object failed.");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try{
			UnityEngine.Rendering.SphericalHarmonicsL2 self=(UnityEngine.Rendering.SphericalHarmonicsL2)checkSelf(l);
			self.Clear();
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddAmbientLight(IntPtr l) {
		try{
			UnityEngine.Rendering.SphericalHarmonicsL2 self=(UnityEngine.Rendering.SphericalHarmonicsL2)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.AddAmbientLight(a1);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddDirectionalLight(IntPtr l) {
		try{
			UnityEngine.Rendering.SphericalHarmonicsL2 self=(UnityEngine.Rendering.SphericalHarmonicsL2)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.AddDirectionalLight(a1,a2,a3);
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Multiply(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Rendering.SphericalHarmonicsL2),typeof(float))){
				UnityEngine.Rendering.SphericalHarmonicsL2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Rendering.SphericalHarmonicsL2 ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(float),typeof(UnityEngine.Rendering.SphericalHarmonicsL2))){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.Rendering.SphericalHarmonicsL2 a2;
				checkType(l,2,out a2);
				UnityEngine.Rendering.SphericalHarmonicsL2 ret=a1*a2;
				pushValue(l,ret);
				return 1;
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
	static public int op_Addition(IntPtr l) {
		try{
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.SphericalHarmonicsL2 ret=a1+a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Rendering.SphericalHarmonicsL2 a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.SphericalHarmonicsL2 a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.SphericalHarmonicsL2");
		addMember(l,Clear);
		addMember(l,AddAmbientLight);
		addMember(l,AddDirectionalLight);
		addMember(l,op_Multiply);
		addMember(l,op_Addition);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
	}
}
