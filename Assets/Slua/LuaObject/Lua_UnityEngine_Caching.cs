using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Caching : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Caching o;
		if(matchType(l,1)){
			o=new UnityEngine.Caching();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Authorize_s(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String),typeof(System.String),typeof(System.Int64),typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Int64 a3;
				checkType(l,3,out a3);
				System.String a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Caching.Authorize(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.String),typeof(System.Int64),typeof(System.Int32),typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Int64 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.String a5;
				checkType(l,5,out a5);
				System.Boolean ret=UnityEngine.Caching.Authorize(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.String),typeof(System.Int32),typeof(System.Int32),typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.String a5;
				checkType(l,5,out a5);
				System.Boolean ret=UnityEngine.Caching.Authorize(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.String),typeof(System.Int32),typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.String a4;
				checkType(l,4,out a4);
				System.Boolean ret=UnityEngine.Caching.Authorize(a1,a2,a3,a4);
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
	static public int CleanCache_s(IntPtr l) {
		try{
			System.Boolean ret=UnityEngine.Caching.CleanCache();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsVersionCached_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.Caching.IsVersionCached(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MarkAsUsed_s(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.Caching.MarkAsUsed(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spaceFree(IntPtr l) {
		pushValue(l,UnityEngine.Caching.spaceFree);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maximumAvailableDiskSpace(IntPtr l) {
		pushValue(l,UnityEngine.Caching.maximumAvailableDiskSpace);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maximumAvailableDiskSpace(IntPtr l) {
		Int64 v;
		checkType(l,2,out v);
		UnityEngine.Caching.maximumAvailableDiskSpace=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spaceOccupied(IntPtr l) {
		pushValue(l,UnityEngine.Caching.spaceOccupied);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_expirationDelay(IntPtr l) {
		pushValue(l,UnityEngine.Caching.expirationDelay);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_expirationDelay(IntPtr l) {
		int v;
		checkType(l,2,out v);
		UnityEngine.Caching.expirationDelay=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		pushValue(l,UnityEngine.Caching.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.Caching.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ready(IntPtr l) {
		pushValue(l,UnityEngine.Caching.ready);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Caching");
		addMember(l,Authorize_s);
		addMember(l,CleanCache_s);
		addMember(l,IsVersionCached_s);
		addMember(l,MarkAsUsed_s);
		addMember(l,"spaceFree",get_spaceFree,null);
		addMember(l,"maximumAvailableDiskSpace",get_maximumAvailableDiskSpace,set_maximumAvailableDiskSpace);
		addMember(l,"spaceOccupied",get_spaceOccupied,null);
		addMember(l,"expirationDelay",get_expirationDelay,set_expirationDelay);
		addMember(l,"enabled",get_enabled,set_enabled);
		addMember(l,"ready",get_ready,null);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Caching));
	}
}
