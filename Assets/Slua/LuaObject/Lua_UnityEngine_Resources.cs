using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Resources : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Resources o;
		if(matchType(l,1)){
			o=new UnityEngine.Resources();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindObjectsOfTypeAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Type))){
				System.Type a1;
				checkType(l,1,out a1);
				UnityEngine.Object[] ret=UnityEngine.Resources.FindObjectsOfTypeAll(a1);
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
	static public int Load(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Object ret=UnityEngine.Resources.Load(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Type))){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				UnityEngine.Object ret=UnityEngine.Resources.Load(a1,a2);
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
	static public int LoadAsync(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.ResourceRequest ret=UnityEngine.Resources.LoadAsync(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.ResourceRequest ret=UnityEngine.Resources.LoadAsync(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String),typeof(System.Type))){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				UnityEngine.ResourceRequest ret=UnityEngine.Resources.LoadAsync(a1,a2);
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
	static public int LoadAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String),typeof(System.Type))){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				UnityEngine.Object[] ret=UnityEngine.Resources.LoadAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Object[] ret=UnityEngine.Resources.LoadAll(a1);
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
	static public int GetBuiltinResource(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Type),typeof(System.String))){
				System.Type a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UnityEngine.Object ret=UnityEngine.Resources.GetBuiltinResource(a1,a2);
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
	static public int LoadAssetAtPath(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String),typeof(System.Type))){
				System.String a1;
				checkType(l,1,out a1);
				System.Type a2;
				checkType(l,2,out a2);
				UnityEngine.Object ret=UnityEngine.Resources.LoadAssetAtPath(a1,a2);
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
	static public int UnloadAsset(IntPtr l) {
		try{
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Resources.UnloadAsset(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnloadUnusedAssets(IntPtr l) {
		try{
			UnityEngine.AsyncOperation ret=UnityEngine.Resources.UnloadUnusedAssets();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Resources");
		addMember(l,FindObjectsOfTypeAll);
		addMember(l,Load);
		addMember(l,LoadAsync);
		addMember(l,LoadAll);
		addMember(l,GetBuiltinResource);
		addMember(l,LoadAssetAtPath);
		addMember(l,UnloadAsset);
		addMember(l,UnloadUnusedAssets);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Resources));
	}
}
