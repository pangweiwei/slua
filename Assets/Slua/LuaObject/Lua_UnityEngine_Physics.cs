using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Physics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Physics o;
		if(matchType(l,1)){
			o=new UnityEngine.Physics();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2,out a3);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4,a5);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,out a2,a3);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.Raycast(a1,out a2,a3,a4);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
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
	static public int RaycastAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.RaycastAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.RaycastAll(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.RaycastAll(a1,a2);
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
	static public int Linecast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Boolean ret=UnityEngine.Physics.Linecast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Physics.Linecast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Boolean ret=UnityEngine.Physics.Linecast(a1,a2,out a3);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.Linecast(a1,a2,out a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
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
	static public int OverlapSphere(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider[] ret=UnityEngine.Physics.OverlapSphere(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider[] ret=UnityEngine.Physics.OverlapSphere(a1,a2);
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
	static public int CapsuleCast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Boolean ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Boolean ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Single a6;
				checkType(l,6,out a6);
				System.Boolean ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6);
				pushValue(l,ret);
				pushValue(l,a5);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Boolean ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5);
				pushValue(l,ret);
				pushValue(l,a5);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit a5;
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Boolean ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6,a7);
				pushValue(l,ret);
				pushValue(l,a5);
				return 2;
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
	static public int SphereCast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Single a5;
				checkType(l,5,out a5);
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5);
				pushValue(l,ret);
				pushValue(l,a4);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4);
				pushValue(l,ret);
				pushValue(l,a4);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(UnityEngine.RaycastHit),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit a4;
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5,a6);
				pushValue(l,ret);
				pushValue(l,a4);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(UnityEngine.RaycastHit),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(UnityEngine.RaycastHit))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,out a3);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(UnityEngine.RaycastHit),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit a3;
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Boolean ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4,a5);
				pushValue(l,ret);
				pushValue(l,a3);
				return 2;
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
	static public int CapsuleCastAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector3 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4);
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
	static public int SphereCastAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.SphereCastAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit[] ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
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
	static public int CheckSphere(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Physics.CheckSphere(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Boolean ret=UnityEngine.Physics.CheckSphere(a1,a2);
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
	static public int CheckCapsule(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector3),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Boolean ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3);
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
	static public int IgnoreCollision(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Collider),typeof(UnityEngine.Collider),typeof(System.Boolean))){
				UnityEngine.Collider a1;
				checkType(l,1,out a1);
				UnityEngine.Collider a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics.IgnoreCollision(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Collider),typeof(UnityEngine.Collider))){
				UnityEngine.Collider a1;
				checkType(l,1,out a1);
				UnityEngine.Collider a2;
				checkType(l,2,out a2);
				UnityEngine.Physics.IgnoreCollision(a1,a2);
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
	static public int IgnoreLayerCollision(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Boolean))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics.IgnoreLayerCollision(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Physics.IgnoreLayerCollision(a1,a2);
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
	static public int GetIgnoreLayerCollision(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.Physics.GetIgnoreLayerCollision(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kIgnoreRaycastLayer(IntPtr l) {
		pushValue(l,UnityEngine.Physics.kIgnoreRaycastLayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kDefaultRaycastLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics.kDefaultRaycastLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kAllLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics.kAllLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_IgnoreRaycastLayer(IntPtr l) {
		pushValue(l,UnityEngine.Physics.IgnoreRaycastLayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultRaycastLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics.DefaultRaycastLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AllLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics.AllLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravity(IntPtr l) {
		pushValue(l,UnityEngine.Physics.gravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravity(IntPtr l) {
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		UnityEngine.Physics.gravity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minPenetrationForPenalty(IntPtr l) {
		pushValue(l,UnityEngine.Physics.minPenetrationForPenalty);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minPenetrationForPenalty(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics.minPenetrationForPenalty=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounceThreshold(IntPtr l) {
		pushValue(l,UnityEngine.Physics.bounceThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounceThreshold(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics.bounceThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepVelocity(IntPtr l) {
		pushValue(l,UnityEngine.Physics.sleepVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepVelocity(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics.sleepVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepAngularVelocity(IntPtr l) {
		pushValue(l,UnityEngine.Physics.sleepAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepAngularVelocity(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics.sleepAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxAngularVelocity(IntPtr l) {
		pushValue(l,UnityEngine.Physics.maxAngularVelocity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxAngularVelocity(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics.maxAngularVelocity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_solverIterationCount(IntPtr l) {
		pushValue(l,UnityEngine.Physics.solverIterationCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_solverIterationCount(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.Physics.solverIterationCount=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Physics");
		addMember(l,Raycast, "Raycast");
		addMember(l,RaycastAll, "RaycastAll");
		addMember(l,Linecast, "Linecast");
		addMember(l,OverlapSphere, "OverlapSphere");
		addMember(l,CapsuleCast, "CapsuleCast");
		addMember(l,SphereCast, "SphereCast");
		addMember(l,CapsuleCastAll, "CapsuleCastAll");
		addMember(l,SphereCastAll, "SphereCastAll");
		addMember(l,CheckSphere, "CheckSphere");
		addMember(l,CheckCapsule, "CheckCapsule");
		addMember(l,IgnoreCollision, "IgnoreCollision");
		addMember(l,IgnoreLayerCollision, "IgnoreLayerCollision");
		addMember(l,GetIgnoreLayerCollision, "GetIgnoreLayerCollision");
		addMember(l,get_kIgnoreRaycastLayer, "get_kIgnoreRaycastLayer");
		addMember(l,get_kDefaultRaycastLayers, "get_kDefaultRaycastLayers");
		addMember(l,get_kAllLayers, "get_kAllLayers");
		addMember(l,get_IgnoreRaycastLayer, "get_IgnoreRaycastLayer");
		addMember(l,get_DefaultRaycastLayers, "get_DefaultRaycastLayers");
		addMember(l,get_AllLayers, "get_AllLayers");
		addMember(l,get_gravity, "get_gravity");
		addMember(l,set_gravity, "set_gravity");
		addMember(l,get_minPenetrationForPenalty, "get_minPenetrationForPenalty");
		addMember(l,set_minPenetrationForPenalty, "set_minPenetrationForPenalty");
		addMember(l,get_bounceThreshold, "get_bounceThreshold");
		addMember(l,set_bounceThreshold, "set_bounceThreshold");
		addMember(l,get_sleepVelocity, "get_sleepVelocity");
		addMember(l,set_sleepVelocity, "set_sleepVelocity");
		addMember(l,get_sleepAngularVelocity, "get_sleepAngularVelocity");
		addMember(l,set_sleepAngularVelocity, "set_sleepAngularVelocity");
		addMember(l,get_maxAngularVelocity, "get_maxAngularVelocity");
		addMember(l,set_maxAngularVelocity, "set_maxAngularVelocity");
		addMember(l,get_solverIterationCount, "get_solverIterationCount");
		addMember(l,set_solverIterationCount, "set_solverIterationCount");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Physics));
		LuaDLL.lua_pop(l, 1);
	}
}
