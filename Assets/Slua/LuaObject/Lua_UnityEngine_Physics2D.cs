using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Physics2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Physics2D o;
		o=new UnityEngine.Physics2D();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreCollision_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Collider2D a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics2D.IgnoreCollision(a1,a2,a3);
				return 0;
			}
			else if(argc==2){
				UnityEngine.Collider2D a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D a2;
				checkType(l,2,out a2);
				UnityEngine.Physics2D.IgnoreCollision(a1,a2);
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
	static public int GetIgnoreCollision_s(IntPtr l) {
		try{
			UnityEngine.Collider2D a1;
			checkType(l,1,out a1);
			UnityEngine.Collider2D a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.Physics2D.GetIgnoreCollision(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreLayerCollision_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics2D.IgnoreLayerCollision(a1,a2,a3);
				return 0;
			}
			else if(argc==2){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Physics2D.IgnoreLayerCollision(a1,a2);
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
	static public int GetIgnoreLayerCollision_s(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.Physics2D.GetIgnoreLayerCollision(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Linecast_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2,a3,a4,a5);
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
	static public int LinecastAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2);
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
	static public int LinecastNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3);
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
	static public int Raycast_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3,a4,a5,a6);
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
	static public int RaycastAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2);
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
	static public int RaycastNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3);
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
	static public int CircleCast_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4,a5,a6,a7);
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
	static public int CircleCastAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3);
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
	static public int CircleCastNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==8){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4);
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
	static public int BoxCast_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int BoxCastAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==8){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4);
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
	static public int BoxCastNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==9){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				System.Single a9;
				checkType(l,9,out a9);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int GetRayIntersection_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.GetRayIntersection(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.GetRayIntersection(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.GetRayIntersection(a1,a2,a3);
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
	static public int GetRayIntersectionAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.GetRayIntersectionAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.GetRayIntersectionAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.GetRayIntersectionAll(a1);
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
	static public int GetRayIntersectionNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.GetRayIntersectionNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.GetRayIntersectionNonAlloc(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] a2;
				checkType(l,2,out a2);
				System.Int32 ret=UnityEngine.Physics2D.GetRayIntersectionNonAlloc(a1,a2);
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
	static public int OverlapPoint_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1);
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
	static public int OverlapPointAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==1){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1);
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
	static public int OverlapPointNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2);
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
	static public int OverlapCircle_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2);
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
	static public int OverlapCircleAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2);
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
	static public int OverlapCircleNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3);
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
	static public int OverlapArea_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2);
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
	static public int OverlapAreaAll_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2);
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
	static public int OverlapAreaNonAlloc_s(IntPtr l) {
		try{
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3);
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
	static public int get_IgnoreRaycastLayer(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.IgnoreRaycastLayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultRaycastLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.DefaultRaycastLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AllLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.AllLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityIterations(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.velocityIterations);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityIterations(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.velocityIterations=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionIterations(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.positionIterations);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionIterations(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.positionIterations=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravity(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.gravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravity(IntPtr l) {
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.gravity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_raycastsHitTriggers(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.raycastsHitTriggers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_raycastsHitTriggers(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.raycastsHitTriggers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_raycastsStartInColliders(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.raycastsStartInColliders);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_raycastsStartInColliders(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.raycastsStartInColliders=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_changeStopsCallbacks(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.changeStopsCallbacks);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_changeStopsCallbacks(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.changeStopsCallbacks=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityThreshold(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.velocityThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityThreshold(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.velocityThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxLinearCorrection(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxLinearCorrection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxLinearCorrection(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxLinearCorrection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxAngularCorrection(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxAngularCorrection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxAngularCorrection(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxAngularCorrection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxTranslationSpeed(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxTranslationSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxTranslationSpeed(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxTranslationSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxRotationSpeed(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxRotationSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxRotationSpeed(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxRotationSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minPenetrationForPenalty(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.minPenetrationForPenalty);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minPenetrationForPenalty(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.minPenetrationForPenalty=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baumgarteScale(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.baumgarteScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baumgarteScale(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.baumgarteScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baumgarteTOIScale(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.baumgarteTOIScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baumgarteTOIScale(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.baumgarteTOIScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeToSleep(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.timeToSleep);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_timeToSleep(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.timeToSleep=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linearSleepTolerance(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.linearSleepTolerance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linearSleepTolerance(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.linearSleepTolerance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularSleepTolerance(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.angularSleepTolerance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularSleepTolerance(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.angularSleepTolerance=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Physics2D");
		addMember(l,IgnoreCollision_s);
		addMember(l,GetIgnoreCollision_s);
		addMember(l,IgnoreLayerCollision_s);
		addMember(l,GetIgnoreLayerCollision_s);
		addMember(l,Linecast_s);
		addMember(l,LinecastAll_s);
		addMember(l,LinecastNonAlloc_s);
		addMember(l,Raycast_s);
		addMember(l,RaycastAll_s);
		addMember(l,RaycastNonAlloc_s);
		addMember(l,CircleCast_s);
		addMember(l,CircleCastAll_s);
		addMember(l,CircleCastNonAlloc_s);
		addMember(l,BoxCast_s);
		addMember(l,BoxCastAll_s);
		addMember(l,BoxCastNonAlloc_s);
		addMember(l,GetRayIntersection_s);
		addMember(l,GetRayIntersectionAll_s);
		addMember(l,GetRayIntersectionNonAlloc_s);
		addMember(l,OverlapPoint_s);
		addMember(l,OverlapPointAll_s);
		addMember(l,OverlapPointNonAlloc_s);
		addMember(l,OverlapCircle_s);
		addMember(l,OverlapCircleAll_s);
		addMember(l,OverlapCircleNonAlloc_s);
		addMember(l,OverlapArea_s);
		addMember(l,OverlapAreaAll_s);
		addMember(l,OverlapAreaNonAlloc_s);
		addMember(l,"IgnoreRaycastLayer",get_IgnoreRaycastLayer,null,false);
		addMember(l,"DefaultRaycastLayers",get_DefaultRaycastLayers,null,false);
		addMember(l,"AllLayers",get_AllLayers,null,false);
		addMember(l,"velocityIterations",get_velocityIterations,set_velocityIterations,false);
		addMember(l,"positionIterations",get_positionIterations,set_positionIterations,false);
		addMember(l,"gravity",get_gravity,set_gravity,false);
		addMember(l,"raycastsHitTriggers",get_raycastsHitTriggers,set_raycastsHitTriggers,false);
		addMember(l,"raycastsStartInColliders",get_raycastsStartInColliders,set_raycastsStartInColliders,false);
		addMember(l,"changeStopsCallbacks",get_changeStopsCallbacks,set_changeStopsCallbacks,false);
		addMember(l,"velocityThreshold",get_velocityThreshold,set_velocityThreshold,false);
		addMember(l,"maxLinearCorrection",get_maxLinearCorrection,set_maxLinearCorrection,false);
		addMember(l,"maxAngularCorrection",get_maxAngularCorrection,set_maxAngularCorrection,false);
		addMember(l,"maxTranslationSpeed",get_maxTranslationSpeed,set_maxTranslationSpeed,false);
		addMember(l,"maxRotationSpeed",get_maxRotationSpeed,set_maxRotationSpeed,false);
		addMember(l,"minPenetrationForPenalty",get_minPenetrationForPenalty,set_minPenetrationForPenalty,false);
		addMember(l,"baumgarteScale",get_baumgarteScale,set_baumgarteScale,false);
		addMember(l,"baumgarteTOIScale",get_baumgarteTOIScale,set_baumgarteTOIScale,false);
		addMember(l,"timeToSleep",get_timeToSleep,set_timeToSleep,false);
		addMember(l,"linearSleepTolerance",get_linearSleepTolerance,set_linearSleepTolerance,false);
		addMember(l,"angularSleepTolerance",get_angularSleepTolerance,set_angularSleepTolerance,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Physics2D));
	}
}
