using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GeometryUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.GeometryUtility o;
		o=new UnityEngine.GeometryUtility();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateFrustumPlanes_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Camera))){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				UnityEngine.Plane[] ret=UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Matrix4x4 a1;
				checkType(l,1,out a1);
				UnityEngine.Plane[] ret=UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1);
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
	static public int TestPlanesAABB_s(IntPtr l) {
		try{
			UnityEngine.Plane[] a1;
			checkType(l,1,out a1);
			UnityEngine.Bounds a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.GeometryUtility.TestPlanesAABB(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GeometryUtility");
		addMember(l,CalculateFrustumPlanes_s);
		addMember(l,TestPlanesAABB_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GeometryUtility));
	}
}
